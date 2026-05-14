using System;

class Program
{
    static void Main()
    {
        int vida = 100;

        Console.WriteLine("Você tomou dano!");

        vida = vida - 20;

        Console.WriteLine("Vida restante: " + vida);
    }
}