using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<String> ListaHistorico;
        private String Data;
        public Calculadora(String data)
        {
            ListaHistorico = new List<String>();
            Data = data;
        }
        public int Soma(int val1, int val2)
        {
            int res = val1 + val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data" + Data);

            return res;
        }
        public int Subitrair(int val1, int val2)
        {
            int res = val1 - val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data" + Data);

            return res;
        }
        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data" + Data);

            return res;
        }
        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;

            ListaHistorico.Insert(0, "Res: " + res + " - Data" + Data);

            return res;
        }
        public List<String> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}
