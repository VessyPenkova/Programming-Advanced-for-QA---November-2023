using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int position = 2;

        //Act
        string result = StringRotator.RotateRight(input, position);

        //Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "Hello!";
        int position = 0;

        //Act
        string result = StringRotator.RotateRight(input, position);

        //Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {

        // Arrange
        string input = "Hello!";
        int position = 1;

        string expected = "!Hello";

        //Act
        string result = StringRotator.RotateRight(input, position);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";
        int position = -1;

        string expected = "!Hello";

        //Act
        string result = StringRotator.RotateRight(input, position);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";
        int position = 1 + input.Length * 2;

        string expected = "!Hello";

        //Act
        string result = StringRotator.RotateRight(input, position);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
