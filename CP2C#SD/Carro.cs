using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2C_SD
{
    internal class Carro : Veiculo
    {
        public string tipo = "Carro";

        public Carro(string marca, string modelo, int ano) : base(marca, modelo, ano)
        {
        }


        public override void Acelerar()
        {
            Console.WriteLine($"{tipo} acelerando rapidamente");
        }
    }
    
}
