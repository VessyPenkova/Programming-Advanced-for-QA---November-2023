using TestApp___2;

namespace TestApp.Test___2
{
    [TestFixture]
    public class DictionaryIntersectionTests
    {
        [Test]
        public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
        {
            //Arrange
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>();
            Dictionary<string, int> secondDictionary = new Dictionary<string, int>();

            //Act
            Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

            //Assert
            Assert.That(result, Is.Empty);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
        {
            //Arrange
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>()
        {
            { "first" , 1},
            { "second", 2}
        };
            Dictionary<string, int> secondDictionary = new Dictionary<string, int>();

            //Act
            Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

            //Assert
            Assert.That(result, Is.Empty);
            Assert.That(result, Has.Count.EqualTo(0));
            Assert.IsTrue(result.Count == 0);
        }

        [Test]
        public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
        {
            //Arrange
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>()
        {
            { "first" , 1},
            { "second", 2}
        };
            Dictionary<string, int> secondDictionary = new Dictionary<string, int>()
            {
            { "three" , 1},
            { "fourth", 2}
        }; ;

            //Act
            Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

            //Assert
            Assert.That(result, Is.Empty);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
        {
            //Arrange
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>()
        {
            { "first" , 1},
            { "second", 2},
            { "third", 3}
        };
            Dictionary<string, int> secondDictionary = new Dictionary<string, int>()
        {
            { "first" , 1},
            { "second", 2},
            { "fourth", 4}
        };

            Dictionary<string, int> expected = new Dictionary<string, int>()
        {
          { "first" , 1},
          { "second", 2},
        };

            //Act
            Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
            Assert.IsTrue(result.ContainsKey("first"));
            Assert.That(result["first"], Is.EqualTo(1));

            Assert.IsTrue(result.ContainsKey("second"));
            Assert.That(result["second"], Is.EqualTo(2));

            Assert.IsFalse(result.ContainsKey("third"));
            Assert.IsFalse(result.ContainsKey("fourth"));

        }

        [Test]
        public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
        {
            //Arrange
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>()
        {
            { "first" , 1},
            { "second", 2}
        };
            Dictionary<string, int> secondDictionary = new Dictionary<string, int>()
            {
            { "first" , 3},
            { "second", 4}
        }; ;

            //Act
            Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictionary, secondDictionary);

            //Assert
            Assert.That(result, Is.Empty);
            Assert.That(result.Count, Is.EqualTo(0));
        }
    }

}