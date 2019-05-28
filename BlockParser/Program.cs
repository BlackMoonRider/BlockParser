using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockParser
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = @"Text:file.txt(6B);Some string content
Image:img.bmp(19MB);1920х1080
Text:data.txt(12B);Another string
Text:data1.txt(7B);Yet another string
Movie:logan.2017.mkv(19GB);1920х1080;2h12m";

            File[] files = Util.Parse(text);

            foreach (File file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();
        }
    }
}
