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
    }
}
