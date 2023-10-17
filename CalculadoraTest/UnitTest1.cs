using XUnitTDD;

namespace CalculadoraTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
    }
}