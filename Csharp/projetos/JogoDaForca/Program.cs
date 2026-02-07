using System;
using System.Runtime.InteropServices;

class JogoDaForca
{
    static void Main()
    {
        string palavra;
        int palavra_tam, tentativa;
        bool acerto, play_again;
        char letra, choice;
        Console.Clear();
        Console.WriteLine("Bem vindo ao jogo da forca!\n");
        do
        {
            play_again = false;
            Console.Write("[peça para o outro jogador fechar os olhos!]\n Digite a palavra secreta: ");

            palavra = Console.ReadLine();
            palavra_tam = palavra.Length;
            tentativa = 10;
            char[] palSecreta = new char[palavra_tam];

            for (int i=0; i<palavra_tam; i++)
            {
                palSecreta[i] = '_';
            }

            while(tentativa > 0 && new string(palSecreta) != palavra)
            {
                Console.Clear();
                acerto = false;
                Console.WriteLine("Restam {0} Tentativas.", tentativa);

                foreach(char p in palSecreta)
                {
                    Console.Write(p);
                }

                Console.WriteLine("\n");

                Console.Write("Tente alguma letra!: ");
                letra = char.Parse(Console.ReadLine()!);

                for (int k=0; k<palavra_tam; k++)
                {
                    if(letra == palavra[k])
                    {
                        palSecreta[k] = letra;
                        acerto = true;
                    }
                }

                if(acerto == false)
                {
                    tentativa--;
                }
            }
            if(tentativa == 0)
            {
                Console.Clear();
                Console.WriteLine("Você perdeu!");
            }
            else
            {
                Console.Clear();
                foreach(char p in palSecreta)
                {
                    Console.Write(p);
                }
                Console.WriteLine("\nVocê venceu!");
            }

            Console.Write("Jogar novamente?: [s/n]");
            choice = char.Parse(Console.ReadLine());
            if(choice == 's' || choice == 'S'){
                play_again = true;
                Console.Clear();
            }
            
        }while(play_again);
        
    }
}