using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1WebShop
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public List<Artikal> Artikals { get; set; } = new();
    }
}
