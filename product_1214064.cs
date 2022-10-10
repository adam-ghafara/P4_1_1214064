using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214064
{
    public class product_1214064
    {
        // public string myType = "Book";
        private string myType;
        private string myTitle;
        public product_1214064()
        {

        }
        public product_1214064(string type, string title) // Parameter
        {
            this.myType = type;
            this.myTitle = title;
        }
        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
