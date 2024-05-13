using NovosTalentos;

namespace TesteNovosTalentos
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "13/05/2024";
            Calculadora calc = new Calculadora("13/05/2024");

            return calc;
        }


        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(11, 12, 23)]
        public void TesteSoma(int numero1, int numero2, int res)
        {
            Calculadora calc = construirClasse();
            var resultado = calc.somar(numero1, numero2);

            Assert.Equal(res, resultado);
        }


        [Theory]
        [InlineData(12, 5, 7)]
        [InlineData(23, 20, 3)]
        public void TesteSubtracao(int numero1, int numero2, int res)
        {
            Calculadora calc = construirClasse();
            var resultado = calc.subtrair(numero1, numero2);

            Assert.Equal(res, resultado);
        }


        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(12, 10, 120)]
        public void TesteMultiplicacao(int numero1, int numero2, int res)
        {
            Calculadora calc = construirClasse();
            var resultado = calc.multiplicar(numero1, numero2);

            Assert.Equal(res, resultado);
        }


        [Theory]
        [InlineData(24, 3, 8)]
        [InlineData(10, 2, 5)]
        public void TesteDivisao(int numero1, int numero2, int res)
        {
            Calculadora calc = construirClasse();
            var resultado = calc.dividir(numero1, numero2);

            Assert.Equal(res, resultado);
        }


        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }



        [Fact]
        public void TesteBuscar3UltimasOperacoes()
        {
            Calculadora calc = construirClasse();

            calc.somar(1, 2);
            calc.somar(5, 7);
            calc.somar(6, 6);
            calc.somar(7, 9);

            var listaDeOperacoes = calc.retornar3UltimasOperacoes();

            Assert.NotEmpty(calc.retornar3UltimasOperacoes());
            Assert.Equal(3, listaDeOperacoes.Count);
        }
    }
}