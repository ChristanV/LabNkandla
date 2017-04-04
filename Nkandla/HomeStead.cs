using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class HomeStead
    {
        private string Name;
        private string District;
        private string Province;
        private string Country;

        public HomeStead(string _Name, string _District, string _Province, string _Country)
        {
            this.Name = _Name;
            this.District = _District;
            this.Province = _Province;
            this.Country = _Country;
        }

        public override string ToString()
        {
            return "Information:\nName:" + this.Name+ "\nDistrict:" + this.District + "\nProvince:" + this.Province + "\nCountry:" + this.Country + "\n"; 
        }
    }
}
