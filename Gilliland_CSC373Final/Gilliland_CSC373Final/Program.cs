using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerVisionAPI;
using TranslatorTextAPI;

namespace Gilliland_CSC373Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "";
            string res = "null";
            try
            {
                //Get filepath from user input
                Console.Write("This test will take the text from images.\nEnter a filepath now.\n->");
                filePath = Console.ReadLine();
                OCR convert = new OCR();
                Translation tr = new Translation();
                Task.Run(async () =>
                {
                    //Wait for the API to respond 
                    res = await convert.ConvertToText(filePath);
                }).Wait();
                //output the text gained from analysis
                Console.Write(res);
                KeyValuePair<string, string> vp = new KeyValuePair<string, string>(res, "fr-fr");
                Task.Run(async () =>
                {
                    res = await tr.TranslateText(vp);
                }).Wait();
                Console.WriteLine(res);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
