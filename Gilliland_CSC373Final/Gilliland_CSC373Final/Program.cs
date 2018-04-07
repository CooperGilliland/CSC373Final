using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerVisionAPI;

namespace Gilliland_CSC373Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\idealTest.png";
            string res = "null";
            try
            {
                OCR convert = new OCR();
                Task.Run(async () =>
                {
                    res = await convert.ConvertToText(filePath);
                }).Wait();
                Console.Write(res);
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
