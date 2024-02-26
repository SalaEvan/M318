using esempioConsole.models;

namespace esempioTest.models
{
    public class NumeroShould
    {
        [Theory]
        [InlineData(2,"pari")]
        [InlineData(3, "dispari")]
        [InlineData(4, "pari")]
        [InlineData(5, "dispari")]
        [InlineData(10, "pari")]
        public void _1_return_ifPari(int numero, string atteso)
        {
            //arrange
            Numero num = new Numero();

            //act
            string attuale = num.VerificaPari(numero);

            //assert
            Assert.Equal(attuale, atteso);
        }
    }
}