using TestApp___3;

namespace TestApp.Test___3
{

    [TestFixture]
    public class ProductInventoryTests
    {
        private ProductInventory _inventory = null!;

        [SetUp]
        public void SetUp()
        {
            this._inventory = new();
        }

        [Test]
        public void Test_AddProduct_ProductAddedToInventory()
        {
            //Arrange
            string productName = "Banana";
            double productPrice = 100;
            int productQuantity = 10;

            string expectedInventory = $"Product Inventory:{Environment.NewLine}{productName} - Price: ${productPrice:f2} - Quantity: {productQuantity}";

            //Act
            this._inventory.AddProduct(productName, productPrice, productQuantity);
            string result = this._inventory.DisplayInventory();

            //Assert
            Assert.That(result, Is.EqualTo(expectedInventory));
        }

        [Test]
        public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
        {
            //Arrange
            string expected = "Product Inventory:";

            //Act
            string result = this._inventory.DisplayInventory();


            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
        {
            //Arrange
            string firstProductName = "Banana";
            double firstpProductPrice = 100;
            int firstProductQuantity = 10;

            string secondProductName = "aple";
            double secondProductPrice = 10;
            int secondProductQuantity = 5;

            string expectedInventory = $"Product Inventory:{Environment.NewLine}{firstProductName} - Price: ${firstpProductPrice:f2} - Quantity: {firstProductQuantity}{Environment.NewLine}{secondProductName} - Price: ${secondProductPrice:f2} - Quantity: {secondProductQuantity}";

            //Act
            this._inventory.AddProduct(firstProductName, firstpProductPrice, firstProductQuantity);
            this._inventory.AddProduct(secondProductName, secondProductPrice, secondProductQuantity);
            string result = this._inventory.DisplayInventory();

            //Assert
            Assert.That(result, Is.EqualTo(expectedInventory));
        }

        [Test]
        public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
        {
            // Arrange

            //Act
            double result = this._inventory.CalculateTotalValue();

            //Assert
            Assert.That(result, Is.EqualTo(0));

        }

        [Test]
        public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
        {
            //Arrange
            string firstProductName = "Banana";
            double firstpProductPrice = 100;
            int firstProductQuantity = 10;

            string secondProductName = "aple";
            double secondProductPrice = 10;
            int secondProductQuantity = 5;

            string expectedInventory = $"Product Inventory:{Environment.NewLine}{firstProductName} - Price: ${firstpProductPrice:f2} - Quantity: {firstProductQuantity}{Environment.NewLine}{secondProductName} - Price: ${secondProductPrice:f2} - Quantity: {secondProductQuantity}";

            //Act 100*10 = 1000 + 10*5 = 50 == 1050
            this._inventory.AddProduct(firstProductName, firstpProductPrice, firstProductQuantity);
            this._inventory.AddProduct(secondProductName, secondProductPrice, secondProductQuantity);
            double result = this._inventory.CalculateTotalValue();

            //Assert
            Assert.That(result, Is.EqualTo(1050));
        }
    }

}