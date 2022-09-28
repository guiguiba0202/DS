using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
    public class cCarro : Veiculo.Veiculo
    {
        internal string Portas { get; set; }
        internal string Bagagem { get; set; }
        internal string Carroceria { get; set; }

        //Construtor sem paraâmetros:
        public cCarro()
        {
            this.Marca = null;
            this.Modelo = null;
            this.Chassi = null;
            this.Cor = null;
            this.Placa = null;
            this.Portas = null;
            this.Bagagem = null;
            this.Carroceria = null;
        }

        //Construtor com parâmetro:
        public cCarro(string Marca, string Modelo, string Chassi, string Cor, string Placa, string Portas, string Bagagem, string Carroceria)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Chassi = Chassi;
            this.Cor = Cor;
            this.Placa = Placa;
            this.Portas = Portas;
            this.Bagagem = Bagagem;
            this.Carroceria = Carroceria;
        }
        
        //Concat um dos seus métodos, neste caso de concatenação
        public override String Exibir()
        {
            String s = String.Empty;
            s = String.Concat(this.Marca, " ", this.Modelo, this.Chassi, this.Cor, this.Placa, this.Portas, this.Bagagem, this.Carroceria);
            return s;
        }

        
    }
}
