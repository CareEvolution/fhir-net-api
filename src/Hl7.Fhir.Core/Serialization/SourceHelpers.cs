using System;

namespace Hl7.Fhir.Serialization
{
    internal static class SourceHelpers
    {
        public static string Truncate(string str)
        {
            const int maxLength = 40;

            if (str == null || str.Length < maxLength)
            {
                return str;
            }
            return str.Substring(0, maxLength - 3) + "...";
        }

        public static bool IsValidDateTime(string dateTimeString)
        {
            return DateTimeParser.IsValidDateTime(dateTimeString);
        }

        public static bool IsValidDate(string dateString)
        {
            return DateTimeParser.IsValidDate(dateString);
        }

        public static bool TryParseFhirInstant(string instantString, out DateTimeOffset instant)
        {
            return DateTimeParser.TryParseFhirInstant(instantString, out instant);
        }

        public static bool IsValidTime(string timeString)
        {
            return DateTimeParser.IsValidTime(timeString);
        }

        private class DateTimeParser
        {
            private DateTimeParser(string dateTimeString)
            {
                _dateTimeString = dateTimeString ?? string.Empty;
                _position = 0;
            }

            public static bool IsValidDate(string dateString)
            {
                var parser = new DateTimeParser(dateString);
                return parser.TryGetDate(out var _1, out var _2, out var _3)
                    && parser.AtEnd();
            }

            public static bool IsValidDateTime(string dateTimeString)
            {
                var parser = new DateTimeParser(dateTimeString);
                if (!parser.TryGetDate(out var _1, out var _2, out var _3))
                {
                    return false;
                }
                if (parser.AtEnd())
                {
                    return true;
                }
                if (!parser.TrySkipCharacter('T'))
                {
                    return false;
                }
                if (!parser.TryGetTime(out _1, out _2, out _3, out var _4))
                {
                    return false;
                }
                if (!parser.TryGetOffset(out _1, out _2))
                {
                    return false;
                }
                return parser.AtEnd();
            }

            public static bool IsValidTime(string timeString)
            {
                var parser = new DateTimeParser(timeString);
                if (!parser.TryGetTime(out var _1, out var _2, out var _3, out var _4))
                {
                    return false;
                }
                return parser.AtEnd();
            }

            public static bool TryParseFhirInstant(string instantString, out DateTimeOffset dateTimeOffset)
            {
                dateTimeOffset = default;

                var parser = new DateTimeParser(instantString);
                if (!parser.TryGetDate(out var year, out var month, out var day))
                {
                    return false;
                }
                if (!parser.TrySkipCharacter('T'))
                {
                    return false;
                }
                if (!parser.TryGetTime(out var hour, out var minute, out var second, out var ticks))
                {
                    return false;
                }
                if (!parser.TryGetOffset(out var offsetHours, out var offsetMinutes)
                    || !parser.AtEnd())
                {
                    return false;
                }

                var offset = new TimeSpan(offsetHours, offsetMinutes, 0);
                var baseDateTimeOffset = new DateTimeOffset(year, month, day, hour, minute, second, offset);
                if (ticks == 0)
                {
                    dateTimeOffset = baseDateTimeOffset;
                }
                else
                {
                    dateTimeOffset = new DateTimeOffset(baseDateTimeOffset.Ticks + ticks, offset);
                }
                return true;
            }

            private bool TryGetDate(out int year, out int month, out int day)
            {
                month = default;
                day = default;

                // yyyy

                if (!TryGetYear(out year))
                {
                    return false;
                }
                if (AtEnd())
                {
                    return true;
                }

                // yyyy-MM

                if (!TrySkipCharacter('-')
                    || !TryGetMonth(out month))
                {
                    return false;
                }
                if (AtEnd())
                {
                    return true;
                }

                // yyyy-MM-dd

                if (!TrySkipCharacter('-')
                    || !TryGetDay(year, month, out day))
                {
                    return false;
                }

                return true;
            }

            private bool TryGetTime(out int hour, out int minute, out int second, out int ticks)
            {
                minute = default;
                second = default;
                ticks = default;

                // HH:mm

                if (!TryGetFixedNumber(2, out hour)
                    || hour > 23)
                {
                    return false;
                }
                if ( !TrySkipCharacter(':'))
                {
                    return false;
                }
                if (!TryGetFixedNumber(2, out minute)
                    || minute > 59)
                {
                    return false;
                }

                // HH:mm:ss

                if (!TrySkipCharacter(':'))
                {
                    return true;
                }
                if (!TryGetFixedNumber(2, out second)
                    || second > 59)
                {
                    return false;
                }

                // HH:mm:ss.FFFFFFF

                if (!TrySkipCharacter('.'))
                {
                    return true;
                }
                if (!TryGetNumber(7, out ticks, out var ticksDigits))
                {
                    return false;
                }
                while (ticksDigits++ < 7)
                {
                    ticks *= 10;
                }

                return true;
            }

            private bool TryGetOffset( out int hour, out int minute )
            {
                hour = 0;
                minute = 0;

                if (AtEnd())
                {
                    return false;
                }
                var firstCharacter = _dateTimeString[_position];

                // Z
                // z

                if ( firstCharacter == 'Z' || firstCharacter == 'z' )
                {
                    _position++;
                    return true;
                }

                // +H:mm
                // +HH:mm
                // -H:mm
                // -HH:mm

                if (firstCharacter != '+' && firstCharacter != '-')
                {
                    return false;
                }
                var negative = firstCharacter == '-';
                _position++;
                if (!TryGetNumber(2, out hour, out var _)
                    || hour > 14)
                {
                    return false;
                }
                if (!TrySkipCharacter(':'))
                {
                    return false;
                }
                if (!TryGetFixedNumber(2, out minute)
                    || minute > 59
                    || hour >= 14 && minute > 0)
                {
                    return false;
                }
                if (negative)
                {
                    hour = -hour;
                    minute = -minute;
                }
                return true;
            }

            private bool AtEnd()
            {
                return _position >= _dateTimeString.Length;
            }

            private bool TrySkipCharacter(char character)
            {
                if (AtEnd() || _dateTimeString[_position] != character)
                {
                    return false;
                }
                _position++;
                return true;
            }

            private bool TryGetYear(out int year)
            {
                return TryGetFixedNumber(4, out year)
                    && 1 <= year;
            }

            private bool TryGetMonth(out int month)
            {
                return TryGetFixedNumber(2, out month)
                    && 1 <= month && month <= 12;
            }

            private bool TryGetDay(int year, int month, out int day)
            {
                return TryGetFixedNumber(2, out day)
                    && 1 <= day && day <= DateTime.DaysInMonth(year, month);
            }

            private bool TryGetFixedNumber(int numberOfDigits, out int value)
            {
                return TryGetNumber(numberOfDigits, out value, out var actualNumberOfDigits)
                    && numberOfDigits == actualNumberOfDigits;
            }

            private bool TryGetNumber(int maxNumberOfDigits, out int value, out int numberOfDigits)
            {
                value = 0;
                var startPosition = _position;
                var maxPosition = Math.Min(_dateTimeString.Length, startPosition + maxNumberOfDigits);
                while (_position < maxPosition && char.IsDigit(_dateTimeString[_position]))
                {
                    value = value * 10 + (_dateTimeString[_position] - '0');
                    _position++;
                }
                numberOfDigits = _position - startPosition;
                return _position > startPosition;
            }

            private readonly string _dateTimeString;
            private int _position;
        }
    }
}
