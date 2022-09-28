using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    public abstract class Veiculo
    {
        internal string Marca { get; set; }
        internal string Modelo { get; set; }
        internal string Chassi { get; set; }
        internal string Cor { get; set; }
        internal string Placa { get; set; }




        //Métodos:
        public abstract String Exibir();
    }
}
