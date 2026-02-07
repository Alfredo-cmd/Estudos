using System;
using System.Security.Cryptography.X509Certificates;

abstract class Veiculo//Classe abstrata
{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo()
    {
        ligado = false;
        velAtual=0;   
    }

    public void SetLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    public bool GetVeLAtual()
    {
        return velAtual;
    }

    abstract public void Aceleracao(int mult)
    {   
    }

    
}

class Carro : Veiculo
{
    public Carro()
    {
        velMaxima=120;
    }
    public override void Aceleracao(int mult)
    {
        velAtual+=10*mult;
    }
}


class Aula39
{
    static void Main()
    {
        
    }
}