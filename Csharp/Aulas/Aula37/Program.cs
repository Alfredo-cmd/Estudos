using System;
using System.Security.Cryptography.X509Certificates;

class Player
{
    protected string class1;
    public Player(string class1) //Executa esse construtor primeiro
    {
        this.class1 = class1;
    }
}

class Hero : Player
{
    public int life, energy;
    public string name;
    public Hero(int life, int energy, string name) //Esse depois
         :base("Hero")
    {
        this.life = life;
        this.energy = energy;
        this.name = name;
    }
    public string GetClass1()
    {
        return class1;
    }
}


class Aula37
{
    static void Main()
    {
        Hero hero = new Hero(100, 80, "Alfredo");
        Console.WriteLine($"Hero life:...:{hero.life}\nhero energy...:{hero.energy}\nhero name...:{hero.name}\nhero class...:{hero.GetClass1()}");
    }
}