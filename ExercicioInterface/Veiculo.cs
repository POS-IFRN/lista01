using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    class Veiculo
    {
        private string fabricante;
        private string modelo;
        private int ano;
        private double pVenda;

        public string Fabricante
        {
            get
            {
                return fabricante;
            }

            set
            {
                fabricante = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }

            set
            {
                ano = value;
            }
        }

        public double PVenda
        {
            get
            {
                return pVenda;
            }

            set
            {
                pVenda = value;
            }
        }

        public override string ToString()
        {
            return $"Fabricante:{fabricante} - Modelo:{modelo} - Ano:{ano} - Preço de venda:{PVenda}";
        }
    }
}
