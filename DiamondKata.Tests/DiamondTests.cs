using DiamondKata.Console;

namespace DiamondKata.Tests
{
    public class DiamondCreateTests
    {
        private string[] _input;

        [SetUp]
        public void SetUp()
        {
            _input = ["B"];
        }

        [Test]
        public void Create_GivenA_ReturnsA()
        {
            //Arrange
            var expectedResult = "A";
            string[] input = ["A"];

            //Act
            var result = Diamond.Create(input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("test now redundant as repeated characters added to diamond create")]
        public void Create_GivenB_GivesSequencing()
        {
            //Arrange
            var expectedResult = "AB";

            //Act
            var result = Diamond.Create(_input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("test now redundant as new line symbol added to diamond create")]
        public void Create_GivenB_RepeatsCharacters()
        {
            //Arrange
            var expectedResult = "ABB";

            //Act
            var result = Diamond.Create(_input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("test redundant as space either side of character has been added to diamond create")]
        public void Create_GivenB_EachCharIsSeparatedOnNewLine()
        {
            //Arrange
            var expectedResult = "A\n" + "BB\n";

            //Act
            var result = Diamond.Create(_input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("test redundant as space between the middle of repeating characters has been added")]
        public void Create_GivenB_IdentCharsOnEachSide()
        {
            //Arrange
            var expectedResult = " A \n" + "BB\n";

            //Act
            var result = Diamond.Create(_input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("test redundant as bottom half has been added to diamond create")]
        public void Create_GivenB_AddSpaceBetweenChars()
        {
            //Arrange
            var expectedResult = " A \n" + "B B\n";

            //Act
            var result = Diamond.Create(_input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Create_GivenB_PrintsBottomHalf()
        {
            //Arrange
            var expectedResult = " A \n" + "B B\n" + " A ";

            //Act
            var result = Diamond.Create(_input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Create_GivenE_ReturnsExpectedDiamond()
        {
            //Arrange
            var expectedResult = "    A    \n" + "   B B   \n" + "  C   C  \n" + " D     D \n" + "E       E\n" + " D     D \n" + "  C   C  \n" + "   B B   \n" + "    A    ";

            //Act
            var result = Diamond.Create(["E"]);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}