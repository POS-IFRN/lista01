using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    class NumeroComplexo
    {
        private int real;

        public int Real
        {
          get { return real; }
          set { real = value; }
        }
        private int imaginario;

        public int Imaginario
        {
          get { return imaginario; }
          set { imaginario = value; }
        }

        public NumeroComplexo adicaoComplexos(NumeroComplexo n)
        {
            return new NumeroComplexo(Real + n.Real, Imaginario + n.Imaginario);
        }

        public NumeroComplexo subtrairComplexos(NumeroComplexo n)
        {
            return new NumeroComplexo(Real - n.Real, Imaginario - n.Imaginario);
        }

        public NumeroComplexo multiplicarComplexos(NumeroComplexo n)
        {
            return new NumeroComplexo(Real * n.Real - Imaginario * n.Imaginario, Real * n.Imaginario + Imaginario * n.Real);
        }

        public NumeroComplexo dividirComplexos(NumeroComplexo n)
        {
            NumeroComplexo num = new NumeroComplexo(Real, Imaginario);
            num = num.multiplicarComplexos(new NumeroComplexo(n.Real, -1 * n.Imaginario));
            int den = NumeroComplexo.multiplicarconjugados(n);
            return new NumeroComplexo(num.Real / den, num.Imaginario / den); 
        }

        private static int multiplicarconjugados(NumeroComplexo n)
        {
            return Convert.ToInt16(Math.Pow(n.Real, 2)) + Convert.ToInt16(Math.Pow(n.Imaginario, 2));
        }

        public NumeroComplexo(int real, int imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }

        public override string ToString()
        {
            return $"{Real} {Imaginario}i";
        }


    }
}
