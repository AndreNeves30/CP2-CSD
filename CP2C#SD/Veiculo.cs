
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2C_SD
{
    internal class Veiculo
    {
        public string marca;
        public string modelo;
        public int ano;
        public Veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }
        public virtual void Acelerar()
        {
            Console.WriteLine("Veículo acelerando");
        }
    }
}
