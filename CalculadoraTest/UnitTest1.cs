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

        [Theory]
        [InlineData(2, 1, 1)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(2, 0));
        }
    }
}