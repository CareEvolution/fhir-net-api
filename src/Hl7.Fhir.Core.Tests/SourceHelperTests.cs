using Hl7.Fhir.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hl7.Fhir.Core.Tests
{
    [TestClass]
    public class SourceHelperTests
    {
        private const string _validDate = "2012-01-01";
        private const string _invalidDate = "2012/01/01";

        private const string _validInstant = "2012-01-02T03:04:05Z";
        private const string _invalidInstant = "2012-01-02T03.04.05Z";

        private const string _validTime = "01:02:03.400";
        private const string _invalidTime = "01.02.03.400";

        [TestMethod]
        public void IsValidDate_Valid()
        {
            Assert.IsTrue(SourceHelpers.IsValidDate("0001-01-01"));
            Assert.IsTrue(SourceHelpers.IsValidDate("1987-02-28"));
            Assert.IsTrue(SourceHelpers.IsValidDate("1992-02-29"));
            Assert.IsTrue(SourceHelpers.IsValidDate("2000-02-29"));
            Assert.IsTrue(SourceHelpers.IsValidDate("1900-02-28"));
            Assert.IsTrue(SourceHelpers.IsValidDate("9999-12-31"));
        }

        [TestMethod]
        public void IsValidDate_Invalid()
        {
            Assert.IsFalse(SourceHelpers.IsValidDate("0000-01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDate("0001-00-01"));
            Assert.IsFalse(SourceHelpers.IsValidDate("0001-01-00"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987-02-29"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1992-02-30"));
            Assert.IsFalse(SourceHelpers.IsValidDate("2000-02-30"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1900-02-29"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987-13-01"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987-12-32"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987-1-01"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987-01-1"));
            Assert.IsFalse(SourceHelpers.IsValidDate("87-01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987:01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987-01:01"));
            Assert.IsFalse(SourceHelpers.IsValidDate(" 1987-01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDate("1987-01-01 "));
        }

        [TestMethod]
        public void IsValidDateTime_Valid()
        {
            Assert.IsTrue(SourceHelpers.IsValidDateTime("0001-01-01"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1992-02-29"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("2000-02-29"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1900-02-28"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("9999-12-31"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T00:00Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T00:00z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T23:59Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T23:59z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23+00:00"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23-00:00"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23+13:59"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23-13:59"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23+14:00"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23-14:00"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23+4:00"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23-4:00"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T00:00:00Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T23:59:59Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.0000000Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.9999999Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.1234567Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.123456Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.12345Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.1234Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.123Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.12Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.1Z"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-04:00"));
            Assert.IsTrue(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891+07:30"));
        }

        [TestMethod]
        public void IsValidDateTime_Invalid()
        {
            Assert.IsFalse(SourceHelpers.IsValidDateTime("0000-01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("0001-00-01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("0001-01-00"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-29"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1992-02-30"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("2000-02-30"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1900-02-29"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-13-01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-12-32"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-1-01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-01-1"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("87-01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987:01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-01:01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime(" 1987-01-01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-01-01 "));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28 00:00Z"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T00:00x"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T24:00Z"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T00:60Z"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T00:59.00000001Z"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T00:59.Z"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T00:59x"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-15:00"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-14:01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891+15:00"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891+14:01"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-04:0"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-04-00"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891 - 04:00"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-04:00 "));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-xx:00"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime("1987-02-28T15:23:31.891-04:xx"));
            Assert.IsFalse(SourceHelpers.IsValidDateTime(" 1987-02-28T15:23:31.891-04:00"));
        }

        [TestMethod]
        public void TryParseFhirInstant_Valid()
        {
            AssertTryParseFhirInstant("1987-02-28T00:00Z");
            AssertTryParseFhirInstant("1987-02-28T00:00z");
            AssertTryParseFhirInstant("1987-02-28T23:59Z");
            AssertTryParseFhirInstant("1987-02-28T23:59z");
            AssertTryParseFhirInstant("1987-02-28T15:23+00:00");
            AssertTryParseFhirInstant("1987-02-28T15:23-00:00");
            AssertTryParseFhirInstant("1987-02-28T15:23-4:00");
            AssertTryParseFhirInstant("1987-02-28T15:23-4:30");
            AssertTryParseFhirInstant("1987-02-28T15:23+4:00");
            AssertTryParseFhirInstant("1987-02-28T15:23+4:30");
            AssertTryParseFhirInstant("1987-02-28T15:23+13:59");
            AssertTryParseFhirInstant("1987-02-28T15:23-13:59");
            AssertTryParseFhirInstant("1987-02-28T15:23+14:00");
            AssertTryParseFhirInstant("1987-02-28T15:23-14:00");
            AssertTryParseFhirInstant("1987-02-28T00:00:00Z");
            AssertTryParseFhirInstant("1987-02-28T23:59:59Z");
            AssertTryParseFhirInstant("1987-02-28T15:23:31.0000000Z");

            var dateTimeOffset = AssertTryParseFhirInstant("1987-02-28T15:23:31.9999999Z");
            Assert.AreEqual(999, dateTimeOffset.Millisecond);
            Assert.AreEqual(TimeSpan.Zero, dateTimeOffset.Offset);

            dateTimeOffset = AssertTryParseFhirInstant("1987-02-28T15:23:31.1234567Z");
            var otherDataTimeOffset = AssertTryParseFhirInstant("1987-02-28T15:23:31.123456Z");
            Assert.AreEqual(7, dateTimeOffset.Ticks - otherDataTimeOffset.Ticks);

            AssertTryParseFhirInstant("1987-02-28T15:23:31.12345Z");
            AssertTryParseFhirInstant("1987-02-28T15:23:31.1234Z");
            AssertTryParseFhirInstant("1987-02-28T15:23:31.123Z");
            AssertTryParseFhirInstant("1987-02-28T15:23:31.12Z");
            AssertTryParseFhirInstant("1987-02-28T15:23:31.1Z");
            AssertTryParseFhirInstant("1987-02-28T15:23:31.891-04:00");
            AssertTryParseFhirInstant("1987-02-28T15:23:31.891+07:30");

            DateTimeOffset AssertTryParseFhirInstant(string instantString)
            {
                Assert.IsTrue(SourceHelpers.TryParseFhirInstant(instantString, out var instant));
                Assert.IsTrue(DateTimeOffset.TryParse(instantString, out var expected));
                Assert.AreEqual(expected, instant);
                return instant;
            }
        }

        [TestMethod]
        public void TryParseFhirInstant_Invalid()
        {
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("0001-01-01", out var _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1992-02-29", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("2000-02-29", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1900-02-28", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("9999-12-31", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("0000-01-01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("0001-00-01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("0001-01-00", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-29", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1992-02-30", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("2000-02-30", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1900-02-29", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-13-01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-12-32", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-1-01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-01-1", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("87-01-01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987:01-01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-01:01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant(" 1987-01-01", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-01-01 ", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28 00:00Z", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T00:00x", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T24:00Z", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T00:60Z", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T00:59.00000001Z", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T00:59.Z", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T00:59x", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T15:23:31.891-04:0", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T15:23:31.891-04-00", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T15:23:31.891 - 04:00", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T15:23:31.891-04:00 ", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T15:23:31.891-xx:00", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant("1987-02-28T15:23:31.891-04:xx", out _));
            Assert.IsFalse(SourceHelpers.TryParseFhirInstant(" 1987-02-28T15:23:31.891-04:00", out _));
        }

        [TestMethodWithCulture("it-IT")]
        public void IsValidDate_ItalianCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidDate(_validDate));
            Assert.IsFalse(SourceHelpers.IsValidDate(_invalidDate));
        }

        [TestMethodWithCulture("en-US")]
        public void IsValidDate_USCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidDate(_validDate));
            Assert.IsFalse(SourceHelpers.IsValidDate(_invalidDate));
        }

        [TestMethodWithCulture("ar-DZ")]
        public void IsValidDate_ArabicAlgerianCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidDate(_validDate));
            Assert.IsFalse(SourceHelpers.IsValidDate(_invalidDate));
        }

        [TestMethodWithCulture("tr-TR")]
        public void IsValidDate_TurkishCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidDate(_validDate));
            Assert.IsFalse(SourceHelpers.IsValidDate(_invalidDate));
        }

        [TestMethodWithCulture("it-IT")]
        public void IsValidTime_ItalianCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidTime(_validTime));
            Assert.IsFalse(SourceHelpers.IsValidTime(_invalidTime));
        }

        [TestMethodWithCulture("en-US")]
        public void IsValidTime_USCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidTime(_validTime));
            Assert.IsFalse(SourceHelpers.IsValidTime(_invalidTime));
        }

        [TestMethodWithCulture("ar-DZ")]
        public void IsValidTime_ArabicAlgerianCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidTime(_validTime));
            Assert.IsFalse(SourceHelpers.IsValidTime(_invalidTime));
        }

        [TestMethodWithCulture("tr-TR")]
        public void IsValidTime_TurkishCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.IsValidTime(_validTime));
            Assert.IsFalse(SourceHelpers.IsValidTime(_invalidTime));
        }

        [TestMethodWithCulture("it-IT")]
        public void TryParseFhirInstant_ItalianCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.TryParseFhirInstant(_validInstant, out var instant));
            Assert.AreEqual(new DateTimeOffset(2012, 1, 2, 3, 4, 5, TimeSpan.Zero), instant);

            Assert.IsFalse(SourceHelpers.TryParseFhirInstant(_invalidInstant, out instant));
            Assert.AreEqual(default(DateTimeOffset), instant);
        }

        [TestMethodWithCulture("en-US")]
        public void TryParseFhirInstant_USCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.TryParseFhirInstant(_validInstant, out var instant));
            Assert.AreEqual(new DateTimeOffset(2012, 1, 2, 3, 4, 5, TimeSpan.Zero), instant);

            Assert.IsFalse(SourceHelpers.TryParseFhirInstant(_invalidInstant, out instant));
            Assert.AreEqual(default, instant);
        }

        [TestMethodWithCulture("ar-DZ")]
        public void TryParseFhirInstant_ArabicAlgerianCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.TryParseFhirInstant(_validInstant, out var instant));
            Assert.AreEqual(new DateTimeOffset(2012, 1, 2, 3, 4, 5, TimeSpan.Zero), instant);

            Assert.IsFalse(SourceHelpers.TryParseFhirInstant(_invalidInstant, out instant));
            Assert.AreEqual(default(DateTimeOffset), instant);
        }

        [TestMethodWithCulture("tr-TR")]
        public void TryParseFhirInstant_TurkishCulture_UsesFhirSpec()
        {
            Assert.IsTrue(SourceHelpers.TryParseFhirInstant(_validInstant, out var instant));
            Assert.AreEqual(new DateTimeOffset(2012, 1, 2, 3, 4, 5, TimeSpan.Zero), instant);

            Assert.IsFalse(SourceHelpers.TryParseFhirInstant(_invalidInstant, out instant));
            Assert.AreEqual(default, instant);
        }
    }
}
