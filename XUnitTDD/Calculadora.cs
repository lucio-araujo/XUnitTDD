using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTDD
{
    public class Calculadora
    {

        private List<string> listHistorico;

        public Calculadora()
        {
            listHistorico = new List<string>();
        }

        public int Somar(int num1, int num2) 
        {
            int resultado = num1 + num2;
            listHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listHistorico.Insert(0, "Resultado: " + resultado);

            return resultado;
        }

        public List<string> Historico() 
        {
            listHistorico.RemoveRange(3, listHistorico.Count - 3);
            return listHistorico;
        }
    }
}
