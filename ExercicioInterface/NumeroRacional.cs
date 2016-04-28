using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    class NumeroRacional
    {
        private int numerador;

        public int Numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }
        private int denominador;

        public int Denominador
        {
            get { return denominador; }
            set { denominador = value; }
        }

        public NumeroRacional multiplicarRacionais(NumeroRacional f)
        {
            int n = Numerador * f.Numerador;
            int d = Denominador * f.Denominador;
            return new NumeroRacional(n, d);
        }

        public NumeroRacional somarRacionais(NumeroRacional n)
        {
            int dnf = MMC(n.Denominador);
            return new NumeroRacional(Numerador * (dnf / Denominador) + n.Numerador * (dnf / n.Denominador), dnf);
        }

        public NumeroRacional subtrairRacionais(NumeroRacional n)
        {
            int dnf = MMC(n.Denominador);
            return new NumeroRacional(Numerador * (dnf / Denominador) - n.Numerador * (dnf / n.Denominador), dnf);
        }

        public NumeroRacional dividirRacionais(NumeroRacional n)
        {
            return new NumeroRacional(Numerador * n.Denominador, Denominador * n.Numerador);
        }


        private int MDC(int df2)
        {
            int x1, x2;

            if (Denominador < df2)
            {
                x1 = df2;
                x2 = Denominador;
            }
            else
            {
                x1 = Denominador;
                x2 = df2;
            }
            if (x1 % x2 == 0) return x2;
            else return MDC(x1 % x2);
        }

        private int MDC(int df1, int df2)
        {
            int x1, x2;

            if (df1 < df2)
            {
                x1 = df2;
                x2 = df1;
            }
            else
            {
                x1 = df1;
                x2 = df2;
            }
            if (x1 % x2 == 0) return x2;
            else return MDC(x2, x1 % x2);
        }

        private int MMC(int x)
        {

            return Denominador * x / MDC(x);
        }

        public void Simplificar()
        {
            int mdc = MDC(Numerador, Denominador);
            Numerador = Numerador / mdc;
            Denominador = Denominador / mdc;
        }

        public NumeroRacional(int n, int d)
        {
            if (d == 0)
                throw new ArgumentException("Denominador não pode ser zero!");
            Numerador = n;
            Denominador = d;
        }

        public override string ToString()
        {
            return $"{Numerador} / {Denominador}";
        }


    }
}
