using System;
using System.Diagnostics;
using System.Runtime;
using System.Security;
using Microsoft.VisualBasic;

public class Player 
{
    protected int health, energy, baseDamage; 
    protected static Random rnd = new Random();
    protected string name;

    protected Player(int health, int energy, int baseDamage, string name)
    {
        this.health = health; this.energy = energy; this.baseDamage = baseDamage; this.name = name;

    }
    public string Name
    {
        get
        {
            return name;
        }
    }
    public virtual int GetDamage()
    {
        return baseDamage;
    }
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            this.health = value;
        }
    }
    public int Energy
    {
        get
        {
            return energy;
        }
        set
        {
            this.energy = value;
        }
    }

    public int BaseDamage
    {
        get
        {
            return baseDamage;
        }
    }
}

public class Hero : Player
{
    public Hero(string name) : base(100, 50, 15, name)
    {
    }

    public override int GetDamage()
    {
        return baseDamage + rnd.Next(0,6);
    }

    public void Attack(Enemy enemy)
    {
        int damage = GetDamage();
        if(energy >= 5)
        {
            enemy.Health -= damage;
            Energy -= 5;
            Console.WriteLine($"{Name} damaged {enemy.Name} causing {damage} damage");
        }
        else
        {
            Console.WriteLine("You need more energy to Attack.");
        }
    }
    public void Special(Enemy enemy)
    {
        int damage = GetDamage()*2;
        if(energy >= 15)
        {
            enemy.Health -= damage;
            Energy -= 15;
            Console.WriteLine($"{Name} used the special causing damaged {enemy.Name} causing {damage} damage");
        }
        else
        {
            Console.WriteLine("You need more energy to use Special.");
        }
    }

}

public class Enemy : Player
{
    public Enemy() : base(55, 100, 5, "Evil Goblin")
    {
    }

    public override int GetDamage()
    {
        return baseDamage + rnd.Next(0, 3);
    }

    public void Attack(Player player)
    {
        int damage = GetDamage();
        if(energy >= 4)
        {
            player.Health -= damage;
            Energy -= 4;
            Console.WriteLine($"{Name} damaged {player.Name} causing {damage} damage");
        }

    }
    public void Special(Player player)
    {
        if(energy >= 10)
        {
            int damage = GetDamage()*2;
            player.Health -= damage;
            Energy -= 10;
            Console.WriteLine($"{Name} used the special causing damaged {player.Name} causing {damage} damage");
        }

    }

}

public class InfoPlayer
{
    public static void ShowPlayerInfo(Player target)
    {
        Console.Clear();
        Console.WriteLine("Info\n--------");
        Console.WriteLine($"Total health....:{target.Health}");
        Console.WriteLine($"Total Energy..:{target.Energy}");
        Console.WriteLine($"Base Damage...:{target.BaseDamage}");
        Console.WriteLine($"Player Name...:{target.Name}");
    }
    public static void ShowBattleInfo(Player hero, Player enemy)
    {
        Console.WriteLine("\n");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("                        Status                            "); 
        Console.WriteLine($"{hero.Name}.:[health={hero.Health}, Energy={hero.Energy}]");
        Console.WriteLine($"{enemy.Name}.:[health={enemy.Health}, Energy={enemy.Energy}]");
        Console.WriteLine("---------------------------------------------------------");
    }
}

public class FightText
{
    public static void PrintPadding(string text)
    {
        int padding = 14;
        Console.WriteLine(new string(' ', padding) + text);
    }
    public static void FightTexts(Player player, Player enemy)
    {
        int namesLength = player.Name.Length + enemy.Name.Length;

        PrintPadding(new string('*', namesLength+8));
        PrintPadding($"* {player.Name} vs {enemy.Name} *");
        PrintPadding(new string('*', namesLength+8));
    }
}

public class Moves
{
    static int choice, turn = 0;
    public static int MovesPlayer()
    {
        while (true)
        {
            while (true)
            {
                Console.WriteLine("Energy cost:5 -- 15");
                Console.Write("[Attack(1)]-[Special(2)]\n-->");

                string input = Console.ReadLine();
                if(int.TryParse(input, out choice))
                    break;
                
                Console.WriteLine("Type a numeric value");

            }

            if(choice == 1 || choice == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        return choice;
    
    }

    public static void MovesEnemy(Enemy enemy, Player player)
    {
        if(turn < 3)
        {
            turn++;
        }
        else
        {
            turn = 0;
            turn++;
        }
        if(turn == 1)
        {
            enemy.Attack(player);
        }
        if(turn == 2)
        {
            enemy.Attack(player);
        }
        if(turn == 3)
        {
            enemy.Special(player);
        }
    }
    
}

public class FightMechanic
{
    static int move;
    public static void FightMech(Hero player, Enemy enemy)
    {
        while (player.Health > 0 && enemy.Health > 0)
        {
            FightText.FightTexts(player, enemy);
            InfoPlayer.ShowBattleInfo(player, enemy);

            move = Moves.MovesPlayer(player, enemy);
            switch (move)
            {
                case 1:
                    Console.Clear();
                    player.Attack(enemy);
                    break;
            }
            Moves.MovesEnemy(enemy, player);

        }
    }
}

class Game
{
    static void Main()
    {
        string name, menu;
        bool play = false, exit = false;
        string fight;

        Console.Clear();
        Console.WriteLine("Welcome to the TurnGame 2.0!");
        Console.Write("Write a name for you character..: ");
        name = Console.ReadLine();

        Hero hero = new Hero(name);
        Enemy enemy1 = new Enemy();

        do
        {
            Console.Write("[Play] [Info] [Exit] |...:");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "Play":
                case "play":
                    play = true;
                    break;
                case "Info":
                case "info":
                    InfoPlayer.ShowPlayerInfo(hero);
                    break;

                case "Exit":
                case "exit":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Type a valid answer.");
                    break;
            }
            }while(play == false && exit == false);

            if(exit == true)
            {
                Console.Clear();
                Console.WriteLine("Exiting...");
            }

            while(play == true)
            {
                
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"{hero.Name} encountered {enemy1.Name}!");
                Console.Write("[yes/no] Do you challenge him? |...:");
                fight = Console.ReadLine();
                Console.Clear();

                if(fight == "Yes" || fight == "yes")
                {
                    FightMechanic.FightMech(hero, enemy1);
                }
                else if (fight == "No" || fight == "no")
                {
                    play = false;
                }

            }
            
        }
}