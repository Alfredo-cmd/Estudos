using System;

class Aula18
{
    static void Main()
    {
        int[,] n = new int[3,3];
        /*
            0 1 2
            3 4 5
            6 7 8        
        */

        n[0,0] = 0;
        n[0,1] = 1;
        n[0,2] = 2;

        n[1,0] = 3;
        n[1, 1] = 4;
        n[1, 2] = 5;

        n[2, 0] = 6;
        n[2, 1] = 7;
        n[2, 2] = 8;

        for(int i=0; i < 9; i++)
        {
            Console.Write(i);
            if(i == 2)
            {
                Console.Write("\n");
            }
            else if(i == 5)
            {
                Console.Write("\n");
            }

        }
    }
}