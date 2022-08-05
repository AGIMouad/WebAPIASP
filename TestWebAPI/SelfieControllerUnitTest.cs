using Xunit;
using WebAPIASP.Controllers;

namespace TestWebAPI
{
    public class SelfieControllerUnitTest
    {
        [Fact]
        public void shouldReturnSetOfSelfies()
        {
            //ARRANGE
            var controler = new SelfiesController();
            //ACT
            var resultat = controler.Get();
            //Assert
            Assert.NotNull(resultat);
            Assert.True(resultat.GetEnumerator().MoveNext());
        }
    }
}