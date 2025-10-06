using System;
using CP2C_SD;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1 Conceitos fundamentais
            //Explique, com suas próprias palavras, os quatro princípios básicos da Orientação a Objetos
            //Encapsulamento, herança, polimorfismo e abstração. Para cada princípio, cite um exemplo simples em C# que ilustre seu uso. (Referência aos princípios.)
            //Encapsulamento -
            //Herança -
            //Polimorfismo -
            //Abstração -


            //Ex2 Classe vs. objeto
            //Descreva a diferença entre classe e objeto em C#.
            //Em seguida, escreva um pequeno trecho de código que declara uma classe simples e cria uma instância (objeto) dessa classe.



            //Ex3 Modificadores de acesso
            //A apresentação de slide menciona diferentes modificadores de acesso em C#: public, private e protected.
            //Explique o significado de cada um e discuta em que situações eles devem ser utilizados ao projetar classes.


            //Ex4 Sobrecarga e sobrescrita
            //Defina sobrecarga (overloading) e sobrescrita (overriding) de métodos em C#.
            //Explique as diferenças entre esses dois mecanismos de polimorfismo e forneça um exemplo de código para cada caso.




            //Ex5 Classe Livro
            Livro livroex = new Livro("O pequeno Principe", "Antoine de Saint", 1943);
            livroex.ExibirInformacoes();
            Console.WriteLine("");


            //Ex6 Hierarquia de veículos e polimorfismo
            Veiculo[] veiculos = new Veiculo[3];

            veiculos[0] = new Carro("Ford", "Mustang", 2021);
            veiculos[1] = new Moto("Harley-Davidson", "Street 750", 2020);
            veiculos[2] = new Carro("Chevrolet", "Camaro", 2022);

            for (int i = 0; i < veiculos.Length; i++)
            {
                veiculos[i].Acelerar();
            }

        }
    }
}   