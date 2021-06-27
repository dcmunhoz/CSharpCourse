using System;

namespace TiposReferenciaeValor
{
    class Program
    {
        static void Main(string[] args)
        {


            Pessoa p1, p2;

            p1 = new Pessoa("Daniel", 24);
            p2 = p1;

            p1.Idade = 34;

            Console.WriteLine(p2);

        }

    }

    class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome} | Idade: {this.Idade}";
        }
    }

}
