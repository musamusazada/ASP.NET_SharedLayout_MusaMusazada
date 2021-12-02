using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drug.Models
{
    public class cDrug
    {
        public string name;
        public float price;
        public cDrug(string NAME, float PRICE)
        {
            this.name = NAME;
            this.price = PRICE;
        }
    }
}
