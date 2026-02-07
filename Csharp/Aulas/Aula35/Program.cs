using System;

class Player
{
    public string class1;
    public Player(string class1)
    {
        this.class1 = class1;
    }
}

class Hero : Player
{
    public int life, energy;
    public string name;
    public Hero(int life, int energy, string name)
         :base("Hero")
    {
        this.life = life;
        this.energy = energy;
        this.name = name;
    }
}


class Aula35
{
    static void Main()
    {
        Hero hero = new Hero(100, 80, "Alfredo");
        Console.WriteLine($"Hero life:...:{hero.life}\nhero energy...:{hero.energy}\nhero name...:{hero.name}\nhero class...:{hero.class1}");
    }
}