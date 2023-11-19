namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = string.Empty;
            Dictionary<string, List <decimal>> orders = new();
            while (key != "buy")
            {
                key = Console.ReadLine();

                if (key == "buy")
                {
                    break;
                }
                string[] productsParts = key
                    .Split(" ")
                    .ToArray();
                string product = productsParts[0];
                decimal price = decimal.Parse(productsParts[1]);
                decimal quantity = decimal.Parse(productsParts[2]);
                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, new List<decimal>());
                    orders[product].Add(price);
                    orders[product].Add(quantity);
                   // price = minnerTask[product][0];
                }
                else if (orders.ContainsKey(product))
                {
                    orders[product][0]= price;
                    orders[product][1] += quantity;
                }               
            }
            foreach (KeyValuePair<string, List<decimal>> currentProduct in orders)
            {
                string currentProd = currentProduct.Key;
                decimal currentProductPrce = currentProduct.Value[0];
                decimal currentProdictQuantity = currentProduct.Value[1];

                decimal currentProductAmount = currentProductPrce * currentProdictQuantity;
                Console.WriteLine($"{currentProd} -> {currentProductAmount:f2}");
               // Console.WriteLine($"{currentProduct.Key} -> {(currentProduct.Value[0] * currentProduct.Value[1]):f2}");
            }
        }
    }
}

