using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslatorTextAPI;
namespace TranslateTest
{
    class Program
    {
        static void Main()
        {
            KeyValuePair<string, string> vp = new KeyValuePair<string, string> ("Hello", "fr-fr");
            string res = "";
            Translation tr = new Translation();
            Task.Run(async () =>
            {
                res = await tr.TranslateText(vp);
            }).Wait();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
