using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockParser
{
    abstract class File
    {
        protected string name;
        protected string extension;
        protected string size; // TODO: make this a struct that keeps a ulong number of bytes and prints it out to the appropriate format. 

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{name}.{extension}");
            stringBuilder.AppendLine($"\tExtension: {extension}");
            stringBuilder.AppendLine($"\tSize: {size}");

            return stringBuilder.ToString();
        }

        abstract protected void Parse(string data);
    }
}
