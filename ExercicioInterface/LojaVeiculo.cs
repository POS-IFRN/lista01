using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    class LojaVeiculo
    {
        private string nome;
        private string endereco;
        private Veiculo[] estoque;
        private int qtd;

        public Veiculo[] PesquisaPorFabricante(string fabricante)
        {
            return estoque.Where(v => v.Fabricante == fabricante).ToArray();
        }

        public Veiculo[] PesquisaPorModelo(string modelo)
        {
            return estoque.Where(v => v.Modelo == modelo).ToArray();
        }

        public Veiculo[] PesquisaPorFaixaDePreco(double fPreco)
        {
            return estoque.Where(v => v.PVenda <= fPreco).ToArray();
        }

        public Veiculo[] GetEstoque()
        {
            Veiculo[] result = new Veiculo[qtd];
            estoque.CopyTo(result, 0);
            return result;
        }

        public double TotalFinanceiroEstoque()
        {
            return estoque.Sum(v => v.PVenda);
        }

        public LojaVeiculo(string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
            estoque = new Veiculo[100];
        }

        public bool addVeiculo(Veiculo v)
        {
            if (qtd < 100)
            {
                estoque[qtd++] = v;
                return true;
            }
            return false;
        }
    }
}
