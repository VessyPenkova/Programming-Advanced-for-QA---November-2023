namespace _03._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] inputParts = command.Split(" ");
                string serialNumber = inputParts[0];
                string itemName = inputParts[1];
                int itemQuantity = int.Parse(inputParts[2]);
                decimal itemPrice = decimal.Parse(inputParts[3]);

                Item currentItem = new Item(itemName, itemPrice);
                Box currentBox = new Box(serialNumber, currentItem, itemQuantity);

                boxes.Add(currentBox);

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(box => box.PriceforBox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceforBox:f2}");
            }
        }
        public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
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
            public int ItemQuantity { get; set; }

            public decimal PriceforBox { get; set; }
        }
    }
}
