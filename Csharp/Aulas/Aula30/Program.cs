using System;
using System.Linq.Expressions;

public class Jogador
{
    public int energia; public bool vivo; public string nome;
    public Jogador(string n, int e, int v)//Construtor
    {
        energia=100; vivo=true;
        nome = n;
    }
    public Jogador(string n)//Construtor
    {
        energia=100; vivo=true;
        nome = n;
    }

    ~Jogador()//Destrutor
    {
        Console.WriteLine($"Jogador {nome} destruido");
    }

}

class Aula30
{
    static void Main()
    {
        string nome1; string nome2;
        Console.Write("Nome do jogador 1: ");
        nome1 = Console.ReadLine();

        Console.Write("Nome do jogador 2: ");
        nome2 = Console.ReadLine();
        Jogador jogador1 = new Jogador(nome1);
        Jogador jogador2 = new Jogador(nome2);
        

        Console.WriteLine();
        Console.WriteLine($"Nome jogador 1: {jogador1.nome}");
        Console.WriteLine($"Nome jogador 2: {jogador2.nome}");
    }
}