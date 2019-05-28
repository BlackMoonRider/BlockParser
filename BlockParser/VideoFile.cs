using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockParser
{
    class VideoFile : File
    {
        private Resolution resolution;
        private string length;

        public VideoFile(string data)
        {
            Parse(data);
        }

        protected override void Parse(string data)
        {
            string[] nameYearAndRest = data.Split(new char[] { '.' });

            name = $"{nameYearAndRest[0]}.{nameYearAndRest[1]}";

            string[] extensionAndRest = nameYearAndRest[2].Split(new char[] { '(' });

            extension = extensionAndRest[0];

            string[] sizeAndRest = extensionAndRest[1].Split(new string[] { ");" }, StringSplitOptions.None);
            
            size = sizeAndRest[0];

            string[] resolutionAndLength = sizeAndRest[1].Split(new string[] { ";" }, StringSplitOptions.None);

            resolution = new Resolution(resolutionAndLength[0]);
            length = resolutionAndLength[1];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.ToString());
            stringBuilder.AppendLine($"\tResolution: {resolution}");
            stringBuilder.AppendLine($"\tLength: {length}");

            return stringBuilder.ToString();
        }
    }
}
