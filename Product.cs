using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF14
{    
    public enum PrCategorys
    {
        Food,
        Appliances
    }
    
    public class Product
    {
        public string PrName{ get; set; }
        public decimal PrPrice{ get; set; }
        public string PrImage{ get; set; }
        public PrCategorys PrCategory{ get; set; }

        public override string ToString()
        {
            return PrName;
        }
    }


}
