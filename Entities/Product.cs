using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
{
    public class Product : ProductBase
    {
        public double price { get; set; }
        public int stock { get; set; }

       

    }
}
