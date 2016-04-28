using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    class ProgressaoMatematica
    {
        private int pElemento;
        private int razao;
        private bool geometrica;

        public int[] calcularnTermos(int n)
        {
            int[] elementos = new int[n];
            if (n <= 0)
                throw new ArgumentException("O número de elementos não pode ser menor ou igual a 0!");
            for (int i = 1; i <= n; i++)
            {
                if (geometrica) elementos[i] = pElemento * Convert.ToInt16(Math.Pow(razao, i - 1));
                else
                {
                    elementos[i] = pElemento + i * razao;
                }
            }

            return elementos;
        }

        public int calcularnesimoTermo(int n)
        {
            if (geometrica)
                return pElemento * Convert.ToInt16(Math.Pow(razao, n - 1));
            return pElemento + n * razao;
        }

        public int somarnTermos(int n)
        {
            if (geometrica)
                return pElemento * (Convert.ToInt16(Math.Pow(razao, n)) - 1) / (razao - 1);
            return ((pElemento + calcularnesimoTermo(n)) * n) / 2;
        }

        public ProgressaoMatematica(int pElemento, int razao, bool geometrica)
        {
            this.pElemento = pElemento;
            this.razao = razao;
            this.geometrica = geometrica;
        }
    }
}
