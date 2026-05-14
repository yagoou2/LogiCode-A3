using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Simulador de Rank no Valorant ===");
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu rank atual (ex: Ferro, Bronze, Prata): ");
        string rankAtual = Console.ReadLine();

        Console.Write("Quantas vitórias você tem nesta sessão? ");
        int vitorias = int.Parse(Console.ReadLine());

        Console.Write("Quantas derrotas você tem nesta sessão? ");
        int derrotas = int.Parse(Console.ReadLine());

        int rrGanho = vitorias * 25;
        int rrPerdido = derrotas * 20;
        int rrTotal = rrGanho - rrPerdido;

        Console.WriteLine("\n--- Resultado do Simulador ---");
        Console.WriteLine($"Jogador: {nome}");
        Console.WriteLine($"Rank Atual: {rankAtual}");
        Console.WriteLine($"Vitórias: {vitorias} (+{rrGanho} RR)");
        Console.WriteLine($"Derrotas: {derrotas} (-{rrPerdido} RR)");
        Console.WriteLine($"Saldo de RR: {(rrTotal >= 0 ? "+" : "")}{rrTotal}");

        if (rrTotal > 0)
        {
            Console.WriteLine("Você está subindo no ranking! Continue assim!");
        }
        else if (rrTotal < 0)
        {
            Console.WriteLine("Você está perdendo RR. Foque nas vitórias!");
        }
        else
        {
            Console.WriteLine("Seu RR está estável.");
        }

        Console.WriteLine("\nBoa sorte nas próximas partidas!");
        Console.ReadKey();
    }
}   