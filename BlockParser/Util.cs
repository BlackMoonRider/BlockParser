using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockParser
{
    static class Util
    {
        static public File[] Parse(string text)
        {
            string[] newLineDelimited = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            string[] typeAndData;
            string type;
            string data;

            File[] files = new File[newLineDelimited.Length];

            for (int i = 0; i < files.Length; i++)
            {
                typeAndData = newLineDelimited[i].Split(new char[] { ':' }, StringSplitOptions.None);
                type = typeAndData[0];
                data = typeAndData[1];

                switch (type)
                {
                    case "Image":
                        files[i] = new ImageFile(data);
                        break;
                    case "Movie":
                        files[i] = new VideoFile(data);
                        break;
                    default:
                        files[i] = new TextFile(data);
                        break;
                }
            }

            return files;
        }
    }
}
