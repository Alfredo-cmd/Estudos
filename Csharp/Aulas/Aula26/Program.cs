class Aula26{
    static void Main()
    {
       int n1, n2, resto, quoc;

       n1 = 6; n2 = 2;
      quoc = Div(n1, n2, out resto);
       Console.WriteLine("{0}/{1}={2} e resto={3}",n1,n2,quoc,resto);
    }

    static int Div(int d1, int d2, out int rest)
    {
        int res;
        res = d1/d2;
        rest = d1%d2;
        return res;
    }

    
}

