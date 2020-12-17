using System;
using System.Collections.Generic;
using System.Text;

namespace BRailButOnTime
{
    public class Location
    {
        public Location(string name, string zipcode)
        {
            this.name = name;
            this.zipcode = zipcode;
        }

        public string GetName()
        {
            return name;
        }

        public string GetZipCode()
        {
            return zipcode;
        }

        private string name = "";
        private string zipcode = "";
    }
}
