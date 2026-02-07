using System;

public class Jogador
{
    private int energia;
    private string nome;
    public Jogador(string nome)
    {
        this.nome=nome;
        energia=100;
    }

    public int GetEnergia()
    {
        return energia;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetEnergia(int e)
    {
        if (e < 0)
        {
            if(energia+e < 0)
            {
                energia=0;
            }
            else
            {
                energia+=e;
            }
            
            
        }
        else if (e > 0)
        {
             if(energia+e > 100)
            {
                energia=100;
            }
            else
            {
                energia+=e;
            }
        }
    }
}

class Aula33
{
    static void Main()
    {    
        Jogador j1=new Jogador("sla");
        j1.SetEnergia(-30);
        Console.WriteLine($"{j1.GetNome()} \n{j1.GetEnergia()}");
    }
}