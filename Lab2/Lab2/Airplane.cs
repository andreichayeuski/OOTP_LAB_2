using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Lab2
{
    [Serializable]
    public class Airplane
    {
        public static string[] types = new string[3]
        {
            "passengers", "cargo", "military"
        };
        public string ID;
        public string type;
        public Company model;
        public string captain = "";
        public List<Crewman> list_of_crewman;
        public int count_of_spaces;
        public int year;
        public int capacity;
        public string date_of_maintenance;

        public Airplane(string id, string type, Company model, List<Crewman> list, int count_of_spaces, int year, int capacity, string date_of_maintenance)
        {
            this.ID = id;
            this.type = type;
            this.model = model;
            this.list_of_crewman = list;
            foreach (Crewman cr in this.list_of_crewman)
            {
                if (cr.position.Equals("Captain"))
                {
                    this.captain = cr.position + " " + cr.name_second;
                }
            }
            if (this.captain.Equals(""))
            {
                throw new Exception("airplane must have a captain");
            }
            this.count_of_spaces = count_of_spaces;
            this.year = year;
            this.capacity = capacity;
            this.date_of_maintenance = date_of_maintenance;
        }

        public Airplane()
        {

        }

        public override string ToString()
        {
            return this.ID + " " + this.model + ", " + this.type + ", " + this.captain + ", " + this.count_of_spaces + " spaces, " + this.capacity + " kg, " + this.date_of_maintenance + ", " + this.year;
        }
    }
}
