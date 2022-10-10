using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214064
{
    internal class dvd_1214064 : product_1214064
    {
        protected string duration;
        
        public dvd_1214064(string title, string duration) // method constructor
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("ini dari class dvd!!!");
        }
        public string Duration
        {
            get 
            { 
                return duration; 
            }
            set 
            {
                duration = value;
            }
        }

    }
}
