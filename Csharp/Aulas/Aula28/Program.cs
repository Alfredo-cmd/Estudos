using System;
using System.Linq.Expressions;

public class Jogador
{
    public int energia;
    public bool vivo=true;

}

class Aula28
{
    static void Main()
    {
        Jogador jogador = new Jogador();
        jogador.energia = 50;
        
        Console.WriteLine($"Energia jogador 1: {jogador.energia}");
    }
}