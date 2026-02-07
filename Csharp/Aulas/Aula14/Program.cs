using System;


class Aula12
{
    static void Main()
    {
        int n1, n2, med;
        Console.Write("Digite sua primeira nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        med = (n1+n2)/2;
        Console.WriteLine("Sua média é: {0}", med);

        if(med >= 7)
        {
            if(med == 10)
            {
                Console.WriteLine("Parabéns!, você está aprovado com louvor!");    
            }
            else
            {
                Console.WriteLine("Aluno aprovado.");  
            } 
        }
        else if(med >= 4 && med < 7)
        {
            Console.WriteLine("Aluno de recuperação.");
        }
        else
        {
            if(med == 0)
                {
                    Console.WriteLine("Meu deus pai.");
                }
                else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }

    }
}
