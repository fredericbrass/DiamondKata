using DiamondKata.Console;

namespace DiamondKata.Tests
{
    public class DiamondCreateTests
    {
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
        public void Create_GivenB_GivesSequencing()
        {
            //Arrange
            var expectedResult = "AB";
            string[] input = ["B"];

            //Act
            var result = Diamond.Create(input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Create_GivenB_RepeatsCharacters()
        {
            //Arrange
            var expectedResult = "ABB";
            string[] input = ["B"];

            //Act
            var result = Diamond.Create(input);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}