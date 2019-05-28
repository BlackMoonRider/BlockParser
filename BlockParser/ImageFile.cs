using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockParser
{
    class ImageFile : File
    {
        private Resolution resolution;

        public ImageFile(string data)
        {
            Parse(data);
        }

        protected override void Parse(string data)
        {
            string[] nameAndRest = data.Split(new char[] { '.' });
            string[] extensionAndRest = nameAndRest[1].Split(new char[] { '(' });
            string[] sizeAndResolution = extensionAndRest[1].Split(new string[] { ");" }, StringSplitOptions.None);

            name = nameAndRest[0];
            extension = extensionAndRest[0];
            size = sizeAndResolution[0];
            resolution = new Resolution(sizeAndResolution[1]);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.AppendLine($"\tResolution: {resolution}");

            return stringBuilder.ToString();
        }
    }
}
