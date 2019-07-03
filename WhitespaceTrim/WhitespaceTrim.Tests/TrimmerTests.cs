using NUnit.Framework;

namespace WhitespaceTrim.Tests
{
    [TestFixture]
    public class TrimmerTests
    {
        [Test]
        public void Trim_GivenAbc_ShouldReturnAbc()
        {
            // Arrange
            var input = "abc";
            var expectedOutput = "abc";

            // Act
            var actualOutput = Trimmer.Trim(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Trim_GivenAbcSpace_ShouldReturnAbc()
        {
            // Arrange
            var input = "abc ";
            var expectedOutput = "abc";

            // Act
            var actualOutput = Trimmer.Trim(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Trim_GivenAbcBacktickT_ShouldReturnAbc()
        {
            // Arrange
            var input = "abc\t";
            var expectedOutput = "abc";

            // Act
            var actualOutput = Trimmer.Trim(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Trim_GivenSpaceAbc_ShouldReturnAbc()
        {
            // Arrange
            var input = " abc";
            var expectedOutput = " abc";

            // Act
            var actualOutput = Trimmer.Trim(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Trim_GivenComplexStringWithSpacesInBetween_ShouldReturnStringWithoutSpaces()
        {
            // Arrange
            var input = "ab\r\n cd \r\n";
            var expectedOutput = "ab\r\ncd\r\n";

            // Act
            var actualOutput = Trimmer.Trim(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
