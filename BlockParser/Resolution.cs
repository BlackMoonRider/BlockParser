using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockParser
{
    struct Resolution
    {
        private readonly int width;
        private readonly int height;

        public Resolution(string data)
        {
            string[] widthAndHeight = data.Split(new char[] { 'х' }, StringSplitOptions.None);
            width = int.Parse(widthAndHeight[0]);
            height = int.Parse(widthAndHeight[1]);
        }

        public override string ToString()
        {
            return $"{width}x{height}";
        }
    }
}
