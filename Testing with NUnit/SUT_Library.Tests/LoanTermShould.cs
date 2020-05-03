using NUnit.Framework;


namespace SUT_Library.Tests
{
    [TestFixture]
    public class LoanTermShould
    {
        [Test]
        public void ReturnTermInMonths()
        {
            //Arrange
            var sut = new LoanTerm(1);

            //Act
            var months = sut.ToMonths();

            //Assert
            Assert.That(months, Is.EqualTo(12));
        }
    }
}
