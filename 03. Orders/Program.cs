namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = string.Empty;
            Dictionary<string, List <decimal>> minnerTask = new();
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
                if (!minnerTask.ContainsKey(product))
                {
                    minnerTask.Add(product, new List<decimal>());
                    minnerTask[product].Add(price);
                    minnerTask[product].Add(quantity);
                   // price = minnerTask[product][0];
                }
                else if (minnerTask.ContainsKey(product))
                { 
                    minnerTask[product][0]= price;
                    minnerTask[product][1] += quantity;
                }               
            }
            foreach (KeyValuePair<string, List<decimal>> currentProduct in minnerTask)
            {
                string currentProd = currentProduct.Key;
                decimal currentProductPrce = currentProduct.Value[0];
                decimal currentProdictQuantity = currentProduct.Value[1];

                decimal currentProductAmount = currentProductPrce * currentProdictQuantity;
                Console.WriteLine($"{currentProd} -> {currentProductAmount:f2}");
            }
        }
    }
}

//var students = new Dictionary<int, StudentName>()
//        {
//            { 111, new StudentName { FirstName="Sachin", LastName="Karnik", ID=211 } },
//            { 112, new StudentName { FirstName="Dina", LastName="Salimzianova", ID=317 } },
//            { 113, new StudentName { FirstName="Andy", LastName="Ruth", ID=198 } }
//        };