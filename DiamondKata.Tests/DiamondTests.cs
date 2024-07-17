using DiamondKata.Services;

namespace DiamondKata.Tests
{
    public class DiamondCreateTests
    {
        private string[] _input;
        private DiamondService _diamondService;

        [SetUp]
        public void SetUp()
        {
            _input = ["B"];
            _diamondService = new DiamondService();
        }

        [Test]
        public void Create_GivenA_ReturnsA()
        {
            //Arrange
            var expectedResult = "A";
            string[] input = ["A"];

            //Act
            var result = _diamondService.Create(input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Create_GivenB_PrintsBottomHalf()
        {
            //Arrange
            var expectedResult = " A \n" + "B B\n" + " A ";

            //Act
            var result = _diamondService.Create(_input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Create_GivenE_ReturnsExpectedDiamond()
        {
            //Arrange
            var expectedResult = "    A    \n" + "   B B   \n" + "  C   C  \n" + " D     D \n" + "E       E\n" + " D     D \n" + "  C   C  \n" + "   B B   \n" + "    A    ";

            //Act
            var result = _diamondService.Create(["E"]);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase("CC")]
        [TestCase("6")]
        [TestCase("*")]
        public void Create_GivenBadCharacter_ThrowsException(string input)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => _diamondService.Create([input]));
        }
    }
}