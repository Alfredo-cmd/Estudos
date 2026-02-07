using System;
class Aula15
{
    static void Main()
    {
        int n1, n2, res;
        string resp;
        Console.WriteLine("Bem vindo a pior calculadora do mundo!!!\n\n");
        
        Console.WriteLine("Digite a operação que deseja fazer: \nMultiplicar[m] - Dividir[d] - Somar[s] - Subtrair[su]");
        resp = Console.ReadLine();
        
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        switch(resp)
        {
            case "m":
            case "M":
                res = n1*n2;
                Console.WriteLine("{0}*{1}={2}",n1,n2,res);
                break;
            case "d":
            case "D":
                res = n1/n2;
                Console.WriteLine("{0}/{1}={2}",n1,n2,res);
                break;
            case "s":
            case "S":
                res = n1+n2;
                Console.WriteLine("{0}+{1}={2}",n1,n2,res);
                break;
            case "su":
            case "Su":
                res = n1-n2;
                Console.WriteLine("{0}-{1}={2}",n1,n2,res);
                break;
            default:
                Console.WriteLine("Por favor digite uma escolha válida.");
                break;
        }

    }
}