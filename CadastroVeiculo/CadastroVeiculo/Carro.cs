using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsVeiculo
{
    public class Carro : Veiculo.Veiculo
    {
        private string portas;
        private string bagagem;
        private string carroceria;


        public Carro()
        {
            this.portas = null;
            this.bagagem = null;
            this.carroceria = null;
        }

        public Carro(string marca, string modelo, string chassi, string cor, string placa, string portas, string bagagem, string carroceria)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Chassi = chassi;
            this.Cor = cor;
            this.Placa = placa;
            this.Portas = portas;
            this.Bagagem = bagagem;
            this.Carroceria = carroceria;
        }

        public string Portas
        {
            get { return portas; }
            set { portas = value; }
        }

        public string Bagagem
        {
            get { return bagagem; }
            set { bagagem = value; }
        }

        public string Carroceria
        {
            get { return carroceria; }
            set { carroceria = value; }
        }

        public override string FunfaLogo()
        {
            String s = String.Empty;
            s = String.Concat("Marca: ", this.Marca, "\n", "Modelo: ", this.Modelo, "\n", "Chassi: ", this.Chassi, "\n", "Cor: ", this.Cor, "\n", "Placa: ", this.Placa, "\n", "N° de portas: ", this.Portas, "\n", "Quantidade de bagagens: ", this.Bagagem, "\n", "Carroceria: ", this.Carroceria, "\n");
            return s;
        }
    }
}
