using System;

class Aula10
{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Sexta, Sábado};

    static void Main()
    {
        //DiasSemana ds= DiasSemana.Domingo;
        //DiasSemana ds = (DiasSemana)3;
        int ds=(int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}