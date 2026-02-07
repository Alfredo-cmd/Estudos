using System;

class Veiculo
{
    public int rodas;
    public int velMax;
    private bool ligado;
    public void Ligar()
    {
        ligado = true;

    }
    public void Desligar()
    {
        ligado = false;
    }
}

class Carro : Veiculo
{
   public string nome, cor;
    public Carro(string nome, string cor)
    {
        Desligar();
        rodas=4;
        velMax=120;
        this.nome = nome;
        this.cor = cor;

    }
}


class Aula34
{
    static void Main()
    {
        Carro c1=new Carro("Rapidao", "Vermelho");

        Console.WriteLine($"Cor: {c1.cor}");
        Console.WriteLine($"Nome: {c1.nome}");
        Console.WriteLine($"Rodas: {c1.rodas}");
        Console.WriteLine($"Velocidade maxima: {c1.velMax}");
        
    }
}