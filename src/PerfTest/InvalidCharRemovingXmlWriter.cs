using System.IO;
using System.Text;
using System.Xml;

namespace PerfTest
{
    public class InvalidCharRemovingXmlWriter : XmlTextWriter
    {
        public InvalidCharRemovingXmlWriter(TextWriter textWriter)
            : base(textWriter)
        {
            // match XmlSerializer defaults for a TextWriter
            Formatting = Formatting.Indented;
            Indentation = 2;
        }

        public InvalidCharRemovingXmlWriter(Stream stream)
            : base(stream, new UTF8Encoding(false))
        {
            // Empty
        }

        public override void WriteString(string text)
        {
            if (text != null && text.Length > 0)
            {
                var bufferSize = 1024;
                var length = text.Length;
                if (length < bufferSize)
                {
                    bufferSize = length;
                }
                var buffer = new char[bufferSize];
                var bufferIndex = 0;
                for (var textIndex = 0; textIndex < length; ++textIndex)
                {
                    var ch = text[textIndex];
                    if (XmlConvert.IsXmlChar(ch))
                    {
                        if (bufferIndex >= bufferSize)
                        {
                            base.WriteChars(buffer, 0, bufferIndex);
                            bufferIndex = 0;
                        }
                        buffer[bufferIndex++] = ch;
                    }
                    else if (textIndex + 1 < length && XmlConvert.IsXmlSurrogatePair(text[textIndex + 1], ch))
                    {
                        if (bufferIndex + 1 >= bufferSize)
                        {
                            base.WriteChars(buffer, 0, bufferIndex);
                            bufferIndex = 0;
                        }
                        buffer[bufferIndex++] = ch;
                        buffer[bufferIndex++] = text[textIndex + 1];
                        textIndex++;
                    }
                }
                if (bufferIndex > 0)
                {
                    base.WriteChars(buffer, 0, bufferIndex);
                }
            }
        }
    }
}
