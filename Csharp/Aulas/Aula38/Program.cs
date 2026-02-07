using System;
using System.Security.Cryptography.X509Certificates;

class Player
{
    protected string class1;
    public virtual void ClassDef() //Executa esse construtor primeiro
    {
        class1 = "empty";
        Console.WriteLine(class1);
    }
}

class Hero : Player
{
    public int life, energy;
    public string name;
    public Hero(int life, int energy, string name) //Esse depois
    {
        this.life = life;
        this.energy = energy;
        this.name = name;
    }
    public override void ClassDef()
    {
        base.ClassDef();
        class1 = "Hero";
        Console.WriteLine(class1);
    }
    public string GetClass1()
    {
        return class1;
    }
}


class Aula38
{
    static void Main()
    {
        Hero hero = new Hero(100, 80, "Alfredo");
        //Console.WriteLine($"Hero life:...:{hero.life}\nhero energy...:{hero.energy}\nhero name...:{hero.name}\nhero class...:{hero.GetClass1()}");
        hero.ClassDef();
    }
}