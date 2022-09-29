using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    public abstract class Veiculo
    {
        private string marca;
        private string modelo;
        private string chassi;
        private string cor;
        private string placa;
        public Veiculo()
        {
            this.marca = null;
            this.modelo = null;
            this.chassi = null;
            this.cor = null;
            this.placa = null;
        }

        public Veiculo(string marca, string modelo, string chassi, string cor, string placa)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Chassi = chassi;
            this.Cor = cor;
            this.Placa = placa;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }


        public abstract String FunfaLogo();
    }
}
