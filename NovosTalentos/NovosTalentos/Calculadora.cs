using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovosTalentos
{
    public class Calculadora
    {
        private List<string> historico;
        private string _data;

        public Calculadora(string data)
        {
            historico = new List<string>();
            _data = data;
        }

        public int somar(int numero1, int numero2)
        {
            var resultadoSoma = numero1 + numero2;
            historico.Insert(0, $"Resultado: {resultadoSoma} | Data: {_data}");
            return resultadoSoma;
        }

        public int subtrair(int numero1, int numero2)
        {
            var resultadoSubtracao = numero1 - numero2;
            historico.Insert(0, $"Resultado: {resultadoSubtracao} | Data: {_data}");
            return resultadoSubtracao;
        }

        public int multiplicar(int numero1, int numero2)
        {
            var resultadoMultiplicacao = numero1 * numero2;
            historico.Insert(0, $"Resultado: {resultadoMultiplicacao} | Data: {_data}");
            return resultadoMultiplicacao;
        }

        public int dividir(int numero1, int numero2)
        {
            var resultadoDivisao = numero1 / numero2;
            historico.Insert(0, $"Resultado: {resultadoDivisao} | Data: {_data}");
            return resultadoDivisao;
        }

        public List<string> retornar3UltimasOperacoes()
        {
            historico.RemoveRange(3, (historico.Count) - 3);
            return historico;
        }
    }
}
