using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214064
{
    internal class book_1214064 : product_1214064
    {
        protected string pageCount;

        public book_1214064(string type, string title, string pagecount) :  base(type, title)
        {
            this.pageCount = pagecount;
        }
        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
