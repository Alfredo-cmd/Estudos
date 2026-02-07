using System;
using System.Runtime.InteropServices;

class Aula22
{
    static void Main()
    {
        int[] num=new int[3]{11,22,33};

       // for(int i = 0; i < num.Length; i++)
       // {
       //    Console.WriteLine(num[i]);
       // }

        foreach(int n in num)
        {
            Console.WriteLine(n);
        }
        
    }
}