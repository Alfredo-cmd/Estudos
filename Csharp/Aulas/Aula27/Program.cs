class Aula27
{
    static void Main()
    {
        //Soma(); Não existem valores a serem somados
        //Soma(10); valores insuficientes
        //Soma(10,20,30,40,50,60); certo
    }

    static void Soma(params int[]n)
    {
        int res=0;

        if (n.Length < 1)
        {
            Console.WriteLine("Não existem valores a serem somados");
        }else if(n.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para a soma");
        }
        else
        {
            for(int i=0; i<n.Length; i++)
            {
                res+=n[i];
            }
            Console.WriteLine($"A soma dos valores é {res}");
        }
        Console.WriteLine($"{n1}+{n2}={res}");
    }
}