using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class City : PoliceStation
    {
        private List<string> Licenses { get; set; }
        private PoliceStation PoliceStation { get; set; }

        public City() 
        {
            Licenses = new List<string>();
            PoliceStation = new PoliceStation();
        }

        // The city can either register or retire taxi licenses
        public void RegisterLicense(string license) 
        {
            Licenses.Add(license);
        }

        public void RetireLicense(string license)
        {
            Licenses.Remove(license);
        }
    }
}
