using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    // Data input
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("*** ROMBO ***");
    var n = ConsoleExtension.GetInt("Ingrese el tamaño del rombo: ");

    // Show results
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Clear();

    ShowRhombus(n);

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

void ShowRhombus(int n)
{
    // Mitad superior
    for (int i = 1; i <= n; i++)
    {
        Console.Write(new string(' ', n - i));
        Console.Write("#");
        if (i > 1)
        {
            Console.Write(new string(' ', 2 * i - 3));
            Console.Write("#");
        }
        Console.WriteLine();
    }

    // Mitad inferior
    for (int i = n - 1; i >= 1; i--)
    {
        Console.Write(new string(' ', n - i));
        Console.Write("#");
        if (i > 1)
        {
            Console.Write(new string(' ', 2 * i - 3));
            Console.Write("#");
        }
        Console.WriteLine();
    }
}