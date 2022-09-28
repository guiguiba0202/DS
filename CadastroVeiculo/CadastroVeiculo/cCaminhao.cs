using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
    public class cCaminhao : Veiculo.Veiculo
    {
        internal string Portas { get; set; }
        internal string Capacidade { get; set; }
        internal string Cabine { get; set; }

        //Construtor sem parâmetro: 
        public cCaminhao()
        {
            this.Marca = null;
            this.Modelo = null;
            this.Chassi = null;
            this.Cor = null;
            this.Placa = null;
            this.Portas = null;
            this.Capacidade = null;
            this.Cabine = null;
        }

        //Construtor com parâmetro:
        public cCaminhao(string Marca, string Modelo, string Chassi, string Cor, string Placa, string Portas, string Capacidade, string Cabines)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Chassi = Chassi;
            this.Cor = Cor;
            this.Placa = Placa;
            this.Portas = Portas;
            this.Capacidade = Capacidade;
            this.Cabine = Cabine;
        }

        //Métodos:
        public override string Exibir()
        {
            String s = String.Empty;
            s = String.Concat(this.Marca, " ", this.Modelo, this.Chassi, this.Cor, this.Placa, this.Portas, this.Bagagem, this.Carroceria);
            return s;
        }
    }
}
