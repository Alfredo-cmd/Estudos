using System;

class Aula08
{
    static void Main()
    {
        int n1, n2, res;
        Console.Write("Digite valor de n1: ");
        n1=int.Parse(Console.ReadLine());
        Console.Write("Digite valor de n2: ");
        n2=Convert.ToInt32(Console.ReadLine());

        res = n1+n2;

        Console.WriteLine("{0}+{1}={2}",n1,n2,res);
    }
}