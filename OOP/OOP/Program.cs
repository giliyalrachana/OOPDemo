using System;

namespace OOP
{
    class Program
    {
        // This program demo. how to use single inheritance
        static void Main(string[] args)
        {
            NOKIA1400 nokia1400 = new NOKIA1400();
            nokia1400.ModelNo = 123;
            nokia1400.ModelName = "NOKIA1400";
            nokia1400.Year = 2005;

            Console.WriteLine(nokia1400.AboutMobilePhone());
            Console.WriteLine(nokia1400.Calling());
            Console.WriteLine(nokia1400.SMS());
            Console.ReadLine();
        }
    }
}
