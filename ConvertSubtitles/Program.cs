using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSubtitles
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Converter.ConverterVttToSrt(args[0]);
                Console.WriteLine("done!");
            }
            else
            {
                Console.WriteLine("drop subs to the app");
            }
            Console.ReadKey();
        }
    }
}
