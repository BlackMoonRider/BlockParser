using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockParser
{
    class TextFile : File
    {
        private string content;

        public TextFile(string data)
        {
            Parse(data);
        }

        protected override void Parse(string data)
        {
            string[] nameAndRest = data.Split(new char[] { '.' });
            string[] extensionAndRest = nameAndRest[1].Split(new char[] { '(' });
            string[] sizeAndContent = extensionAndRest[1].Split(new string[] { ");" }, StringSplitOptions.None);

            name = nameAndRest[0];
            extension = extensionAndRest[0];
            size = sizeAndContent[0];
            content = sizeAndContent[1];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.AppendLine($"\tContent: {content}");

            return stringBuilder.ToString();
        }
    }
}
