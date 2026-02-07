using System;

class Aula20
{
    static void Main()
    {
        bool continuar = false;
        double num, res;
        char resp;
        do
        {
            Console.Write("Bem vindo a tabuada!, deseja ver a tabuada de qual número?: ");
            num = int.Parse(Console.ReadLine()!);

            for(int i=0; i<=10; i++)
            {
                res = num*i;
                Console.WriteLine("{0}x{1}={2}",num,i,res);
            }

            Console.WriteLine("Deseja ver a tabuada de outro número?: [s/n]");
            resp = char.Parse(Console.ReadLine()!);
            if (resp == 's' || resp == 'S')
            {
                Console.Clear();
                continuar = true;
            }
            else if(resp == 'n' || resp == 'N')
            {
                Console.WriteLine("Obrigado por usar o meu programa!");
                continuar = false;
            }
            else
            {
                Console.WriteLine("Por favor, digite uma opção válida.");
                continuar = true;
            }
        }while(!continuar);
    }
}