using System;

class Aula19{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}
    static void Main()
    {
        string esc;

        Console.Write("Deseja ver os dias da semana?: [s/n]");
        esc = Console.ReadLine()!;

        switch (esc)
        {
            case "s":
            case "S":
                for(int i=0; i<7; i++)
                {
                    Console.WriteLine((DiasSemana)i);
                }
                break;
            case "n":
            case "N":
                Console.WriteLine("Tá então.");
                break;
            default:
                Console.WriteLine("Digite uma resposta válida.");
                break;
        }
    }
}