using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Country
    {
        public string name;
        public int amount;
        public int medal;
        


        public Country(string name,int amount,int medal)
        {
            this.name = name;  
            this.amount = amount;
            this.medal = medal;
        }
        


        public string GetInformation()
        {
            string information;
            information = "Kраїна: " + name + "; Спортсмени: " + amount.ToString() + "; Медалі: " + medal.ToString();
            return information;
        }

    }
}
