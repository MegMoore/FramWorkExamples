using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramWorkExamples
{
    public class OrderLines
    {
        public int Id { get; set; }
        public int OrdersId { get; set; }
        public string Product { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Product} | {Description} | {Quantity} | {Price}";
        }

    }
}
