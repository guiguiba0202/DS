using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
    public class Caminhao : Veiculo.Veiculo
    {
        private string portas;
        private string capacidade;
        private string cabine;


        public Caminhao()
        {
            this.portas = null;
            this.capacidade = null;
            this.cabine = null;
        }

        public Caminhao(string marca, string modelo, string chassi, string cor, string placa, string portas, string capacidade, string cabine)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Chassi = chassi;
            this.Cor = cor;
            this.Placa = placa;
            this.Portas = portas;
            this.Capacidade = capacidade;
            this.Cabine = cabine;
        }

        public string Portas
        {
            get { return portas; }
            set { portas = value; }
        }

        public string Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        public string Cabine
        {
            get { return cabine; }
            set { cabine = value; }
        }

        public override string FunfaLogo()
        {
            String s = String.Empty;
            s = String.Concat("Marca: ", this.Marca, "\n", "Modelo: ", this.Modelo, "\n", "Chassi: ", this.Chassi, "\n", "Cor: ", this.Cor, "\n", "Placa: ", this.Placa, "\n", "N° de portas: ", this.Portas, "\n", "Capacidade: ", this.Capacidade, "\n", "Tipo de cabine: ", this.Cabine, "\n");
            return s;
        }
    }
}
