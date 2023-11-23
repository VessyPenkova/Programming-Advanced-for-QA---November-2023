using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03._Store_Boxes
{
    public class Box
    {
        public Box(string serilaNumber, Item item, int itemQuantity)
        {
            SerialNumber = serilaNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceforBox = item.Price * itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity  { get; set; }

        public decimal PriceforBox { get; set; }
    }
}

// Serial Number, Item, Item Quantity and Price for a Box.
