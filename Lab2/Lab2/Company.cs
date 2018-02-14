using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Company
    {
        public string name;
        public string country;
        public int year;
        public List<string> types;

        public Company(string name, string country, int year, List<string> list)
        {
            this.name = name;
            this.country = country;
            this.year = year;
            this.types = list;
        }

        public Company()
        {

        }

        public string ShowAllInformation()
        {
            string type = "";
            foreach (string s in this.types)
            {
                if (type.Equals(""))
                {
                    type += s;
                }
                else
                {
                    type += "/" + s;
                }
            }
            return this.ToString() + ", " + this.country + ", " + this.year + " - year of foundation, types: " + type;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
