using TestApp___2___2;

namespace _1902._TestApp.Tests
{
    [TestFixture]
    public class FruitsTests
    {
        [Test]
        public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
        {
            //Arrange

            Dictionary<string, int> fruitDictionary = new Dictionary<string, int>()
            {
                ["aple"] = 1,
                ["orange"] = 2
            };

            string searchedFruduid = "aple";

            //Act
            int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruduid);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
        {
            //Arrange

            Dictionary<string, int> fruitDictionary = new Dictionary<string, int>()
            {
                ["aple"] = 1
            };
            string searchedFruduid = "banana";

            //Act
            int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruduid);
            //Assert

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
        {
            //Arrange
            Dictionary<string, int> fruitDictionary = new Dictionary<string, int>();

            string wantedFruid = "banana";

            //Act
            int result = Fruits.GetFruitQuantity(fruitDictionary, wantedFruid);
            //Assert

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
        {
            //Arrange

            Dictionary<string, int>? fruitDictionary = null;

            string wantedFruid = "banana";

            //Act
            int result = Fruits.GetFruitQuantity(fruitDictionary, wantedFruid);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
        {
            Dictionary<string, int> fruitDictionary = new Dictionary<string, int>()
            {
                ["aple"] = 1
            };
            string searchedFruduid = null;
            //Act
            int result = Fruits.GetFruitQuantity(fruitDictionary, searchedFruduid);
            //Assert

            Assert.That(result, Is.EqualTo(0));
        }
    }

}