using TestApp___03___01;

namespace TestApp.Test___03___01
{
    [TestFixture]
    public class SubstringExtractorTests
    {
        [Test]
        public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
        {
            //Arrange

            string input = "aaa bbb ccc";
            string startMatrker = "aaa";
            string endMarker = "ccc";

            //Act
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMatrker, endMarker);

            //Assert
            Assert.That(result, Is.EqualTo(" bbb "));
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
        {
            //Arrange

            string input = "aaa bbb ccc";
            string startMatrker = "dd";
            string endMarker = "ccc";

            //Act
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMatrker, endMarker);

            //Assert
            Assert.That(result, Is.EqualTo("Substring not found"));
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
        {
            //Arrange

            string input = "aaa bbb ccc";
            string startMatrker = "aaa";
            string endMarker = "dd";

            //Act
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMatrker, endMarker);

            //Assert
            Assert.That(result, Is.EqualTo("Substring not found"));
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
        {
            //Arrange

            string input = "aaa bbb ccc";
            string startMatrker = "ee";
            string endMarker = "dd";

            //Act
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMatrker, endMarker);

            //Assert
            Assert.That(result, Is.EqualTo("Substring not found"));
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
        {
            //Arrange

            string input = "";
            string startMatrker = "ee";
            string endMarker = "dd";

            //Act
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMatrker, endMarker);

            //Assert
            Assert.That(result, Is.EqualTo("Substring not found"));
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
        {
            //Arrange

            string input = "eedd";
            string startMatrker = "ee";
            string endMarker = "ed";

            //Act
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMatrker, endMarker);

            //Assert
            Assert.That(result, Is.EqualTo("Substring not found"));
        }
    }
}