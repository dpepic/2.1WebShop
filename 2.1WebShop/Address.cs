using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1WebShop
{
    internal class Address
    {
        public int Id { get; set; }
        public string City { get; set; } = string.Empty;
        public string PoBox { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string StreetNo { get; set; } = string.Empty;
    }
}
