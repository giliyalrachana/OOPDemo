using System;

namespace OOP
{
    // This program demo. how to use Multilevel inheritance
    class MultiLevelInheritance
    {
        static void Main()
        {
            NOKIA1100 nokia1100 = new NOKIA1100();
            nokia1100.ModelNo = 1234;
            nokia1100.ModelName = "NOKIA1100";
            nokia1100.Year = 2000;
            Console.WriteLine(nokia1100.AboutMobilePhone());
            Console.WriteLine(nokia1100.Calling());
            Console.WriteLine(nokia1100.SMS());
            Console.WriteLine(nokia1100.MP3());
            Console.WriteLine(nokia1100.MP4());
            Console.ReadLine();
        }
    }
}
