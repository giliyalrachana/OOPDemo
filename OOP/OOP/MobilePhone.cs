using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class MobilePhone
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public MobilePhone()
        {
            Console.WriteLine("Default constructor of Mobile Phone:");
        }
        public MobilePhone(int modelNo, string modelName, int year)
        {
            this.ModelNo = modelNo;
            this.ModelName = modelName;
            this.Year = year;

        }
        public string Calling()
        {
            return "Calling() from MobilePhone";
        }
        public string SMS()
        {
            return "SMS() from MobilePhone";
        }
        public string AboutMobilePhone()
        {
            return $"Model No={this.ModelNo}\nModelName={this.ModelName}\nyear={this.Year}";
        }
    }
}



  
