// See https://aka.ms/new-console-template for more information
using MiniMegaSena;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jogo da Mega Sena!");
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        string jogarNovamente;

        do
        {
            Console.WriteLine($"Olá, {nome}! Escolha o nível do jogo:");
            Console.WriteLine("1 - Nível 1 (números de 1 a 30)");
            Console.WriteLine("2 - Nível 2 (números de 1 a 60)");
            Console.Write("Opção: ");
            int nivel = int.Parse(Console.ReadLine());

            MegaSena jogo;

            if (nivel == 1)
                jogo = new MegaNivel1();   // polimorfismo
            else
                jogo = new MegaNivel2();   // polimorfismo

            Console.WriteLine();
            Console.WriteLine("Informe 6 números (separadamente):");

            List<int> numerosUsuario = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numerosUsuario.Add(int.Parse(Console.ReadLine()));
            }

            jogo.Sortear();

            int acertos = jogo.Verificar(numerosUsuario);
            Console.WriteLine($"Você acertou {acertos} números.");

            jogo.ExibirResultado(acertos);

            Console.WriteLine("\nDeseja jogar novamente? (Sim/Não)");
            jogarNovamente = Console.ReadLine().ToLower();

        } while (jogarNovamente == "sim");

        Console.WriteLine("\nObrigado por jogar!");
    }
}