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