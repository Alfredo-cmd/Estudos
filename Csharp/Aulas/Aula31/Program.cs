using System;
using System.Linq.Expressions;

static public class Jogador
{
    static int energia; static bool vivo; static string nome;

    static void Iniciar(string n)//Construtor
    {
        energia=100; vivo=true;
        nome = n;
    }

}

class Aula31
{
    static void Main()
    {
        string nome1; string nome2;
        Console.Write("Nome do jogador 1: ");
        nome1 = Console.ReadLine();

        Console.Write("Nome do jogador 2: ");
        nome2 = Console.ReadLine();

        Jogador.Iniciar("Bruno");
        Jogador.info();
        

        Console.WriteLine();
        Console.WriteLine($"Nome jogador 1: {jogador1.nome}");
        Console.WriteLine($"Nome jogador 2: {jogador2.nome}");
    }
}