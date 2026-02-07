using System;
using System.Reflection.PortableExecutable;

class TurnGame
{
    static async Task Main()
    {
        Console.WriteLine("Bem vindo ao jogo de turno: Ovo de páscoa em fatias");
        string decisao; string name_game; string choice;
        Random random = new Random();
        int special_limit, heal_limit;


        Console.Write("Digite um nome para seu personagem: ");
        name_game = Console.ReadLine();


        Player player = new Player(name_game, 100, 15);
        Player enemy = new Player("Monster", 80, 12);

        special_limit = 1; heal_limit = 2;

        var choices = new List<string> { "atacar", "curar", "especial"};
        do
        {

            Console.WriteLine($"Player life = {player.life}\nEnemy life = {enemy.life}");

            for(int i=0; i<choices.Count; i++){
                Console.Write($"[{choices[i]}] ");
            }
            choice = Console.ReadLine().ToLower();


            if(choice == "atacar"){
                player.Attack(enemy, random, name_game);
            }
            else if(choice == "curar"){
                player.Heal(enemy, random, name_game);
                heal_limit --;
            }
            else if(choice == "especial"){
                player.Special(enemy, random, name_game);
                special_limit--;
            }
            if(special_limit == 0){
                choices.RemoveAt(2);
                special_limit = -1;
            }
            if(heal_limit == 0){
                choices.RemoveAt(1);
                heal_limit = -1;
            }

            enemy.EnemyAction(player, random, name_game);

        }while(player.life > 0 && enemy.life > 0);


        if(player.life < 0){
            Console.WriteLine($"{player.name} morreu!, deseja jogar novamente?: [s/n]");
        }
        else if(enemy.life < 0){
            Console.WriteLine($"{player.name} derrotou {enemy.name}! continuar? [s/n]");
        }
        

    }
}

class Player
{
    public string name; public int life;

    public int damage; int heal;

    public void Attack(Player target, Random random, string namePlayer)
    {
        if (name == "Monster")
        {
            damage = random.Next(12, 16);
        }
        else if(name== namePlayer)
        {
            damage = random.Next(7, 14);
        }
        damage = random.Next(12, 16);
        target.life -= damage;
        if(damage > 14)
        {
            Console.WriteLine($"{name} atacou {target.name} e causou {damage} de dano critico!");
        }
        else if(damage >= 10 && damage < 14)
        {
            Console.WriteLine($"{name} atacou {target.name} e causou {damage} de dano!");
        }
        else if(damage == 12)
        {
            Console.WriteLine($"{name} atacou {target.name} e pegou de raspão causando {damage} de dano!");
        }
    }
    public void Special(Player target, Random random, string namePlayer)
    {
        damage = random.Next(25, 31);
        target.life -= damage;

        if(damage >= 29)
        {
            Console.WriteLine($"{name} usou o especial em {target.name} causando {damage} de dano critico!");
        }
        else
        {
            Console.WriteLine($"{name} usou o especial em {target.name} causando {damage} de dano!");
        }
    }


    public void Heal(Player target, Random random, string namePlayer)
    {
        if (name == "Monster")
        {
            heal = random.Next(6, 9);
        }
        else if(name== namePlayer)
        {
            heal = random.Next(4, 7);
        }
        target.life += heal;
        Console.WriteLine($"{name} curou {heal} de vida");
    }
    public Player(string n, int l, int d)
    {
        name = n;
        life = l;
        damage = d;
    }

    public void EnemyAction(Player target, Random random, string namePlayer)
    {
        int action = random.Next(1, 8);
        if (action >= 1 && action <= 5)
            {
                Attack(target, random, namePlayer);
            }
            else if(action > 5 && action < 7)
            {
                Heal(this, random, namePlayer);
            }
            else if(action == 7)
            {
                Special(target, random, namePlayer);
            }
    }

}