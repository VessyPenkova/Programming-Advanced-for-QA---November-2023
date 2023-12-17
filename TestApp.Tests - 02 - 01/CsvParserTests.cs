using _1901._TestApp;

namespace TestApp.Tests___02___01
{
    [TestFixture]
    public class CsvParserTests
    {
        [Test]
        public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
        {
            //Arrange

            string ParseCsv = string.Empty;
            string[] expected = new string[] { };

            //Act
            string[] result = CsvParser.ParseCsv(ParseCsv);

            //Assert
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
        {
            //Arrange

            string ParseCsv = "Hello!  ";
            string[] expected = new[] { "Hello!" };

            //Act
            string[] result = CsvParser.ParseCsv(ParseCsv);

            //Assert
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
        {
            //Arrange

            string ParseCsv = "Hello!,how,are,you,doing?";
            string[] expected = new[]
            { "Hello!",
             "how",
             "are",
             "you",
           "doing?"
        };

            //Act
            string[] result = CsvParser.ParseCsv(ParseCsv);

            //Assert
            Assert.That(result.Length, Is.EqualTo(5));
        }

        [Test]
        public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
        {
            //Arrange

            string ParseCsv = "  Hello!    ,how  ,are  ,  you,    doing?   ";
            string[] expected = new[]
            { "Hello!",
             "how",
             "are",
             "you",
           "doing?"
        };

            //Act
            string[] result = CsvParser.ParseCsv(ParseCsv);

            //Assert
            Assert.That(result.Length, Is.EqualTo(5));
        }
    }


}