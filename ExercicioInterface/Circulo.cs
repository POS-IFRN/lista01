using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    class Circulo
    {
        private double raio;

        public double getArea()
        {
            return Math.Pow(raio, 2) * Math.PI;
        }

        public double getCircunferencia()
        {
            return 2 * Math.PI * raio;
        }

        public Circulo(double raio)
        {
            this.raio = raio;
        }
    }
}
