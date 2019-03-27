using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_3354_2_A4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Downloading file");
                Download();
                Console.ReadLine();
        }

            static void Download()
            {
                Task.Run(() => 
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("Download Complete");
                });

            }
    }
}

    