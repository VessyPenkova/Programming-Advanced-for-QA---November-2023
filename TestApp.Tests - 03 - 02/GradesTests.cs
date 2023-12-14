using TestApp___03___02;

namespace TestApp.Tests___03___02
{

    [TestFixture]
    public class GradesTests
    {
        [Test]
        public void Test_GetBestStudents_ReturnsBestThreeStudents()
        {
            //Arrange
            Dictionary<string, int> gradesDictionary = new Dictionary<string, int>()
            {
                ["George"] = 5,
                ["Ivan"] = 3,
                ["Peter"] = 4,
                ["John"] = 6,
                ["Alex"] = 2
            };

            //Act
            string result = Grades.GetBestStudents(gradesDictionary);
            string expected = $"John with average grade 6.00" +
             $"{Environment.NewLine}George with average grade 5.00" +
              $"{Environment.NewLine}Peter with average grade 4.00";

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
        {
            //Arrange
            Dictionary<string, int> gradesDictionary = new Dictionary<string, int>();

            //Act
            string result = Grades.GetBestStudents(gradesDictionary);
            string expected = "";

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
        {
            //Arrange
            Dictionary<string, int> gradesDictionary = new Dictionary<string, int>()
            {
                ["George"] = 5,
                ["John"] = 6,
            };

            //Act
            string result = Grades.GetBestStudents(gradesDictionary);
            string expected = $"John with average grade 6.00" +
            $"{Environment.NewLine}George with average grade 5.00";


            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
        {
            //Arrange
            Dictionary<string, int> gradesDictionary = new Dictionary<string, int>()
            {
                ["George"] = 5,
                ["John"] = 5,
                ["Peter"] = 5,
                ["Ivan"] = 5,
                ["Alex"] = 5
            };

            //Act
            string result = Grades.GetBestStudents(gradesDictionary);
            string expected = $"Alex with average grade 5.00" +
            $"{Environment.NewLine}George with average grade 5.00" +
            $"{Environment.NewLine}Ivan with average grade 5.00";

            //
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}