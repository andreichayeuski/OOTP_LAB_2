using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Crewman
    {
        public string name_first;
        public string name_second;
        static public string[] list_of_positions = new string[4]
        {
            "Captain", "Second pilot", "Steward", "Ingener"
        };
        public string position;
        public int age;
        public int experience;
        public string sex;

        public Crewman(string name_first, string name_second, string position, string sex, int age, int experience)
        {
            this.age = age;
            this.experience = experience;
            this.name_first = name_first;
            this.name_second = name_second;
            this.sex = sex;
            this.position = position;
        }

        public Crewman()
        {

        }

        public override string ToString()
        {
            return  this.name_first + " " + this.name_second + ", " + this.sex + ", " + this.position + ", " + this.age + " years old, " + this.experience + " years of experience";
        }
    }
}
