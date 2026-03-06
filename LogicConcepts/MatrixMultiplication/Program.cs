using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    // Data input
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("*** MULTIPLICACIÓN DE MATRICES ***");
    var m = ConsoleExtension.GetInt("Ingrese el valor de m: ");
    var n = ConsoleExtension.GetInt("Ingrese el valor de n: ");
    var p = ConsoleExtension.GetInt("Ingrese el valor de p: ");

    // Show results
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Clear();

    ShowMatrices(m, n, p);

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

void ShowMatrices(int m, int n, int p)
{
    var A = BuildMatrixA(m, n);
    var B = BuildMatrixB(n, p);
    var C = MultiplyMatrices(A, B, m, n, p);

    PrintMatrix("A", A, m, n);
    PrintMatrix("B", B, n, p);
    PrintMatrix("C", C, m, p);
}

int[,] BuildMatrixA(int m, int n)
{
    int[,] A = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            A[i, j] = (i + 1) * j;
    return A;
}

int[,] BuildMatrixB(int n, int p)
{
    int[,] B = new int[n, p];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < p; j++)
            B[i, j] = (j + 1) * i;
    return B;
}

int[,] MultiplyMatrices(int[,] A, int[,] B, int m, int n, int p)
{
    int[,] C = new int[m, p];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < p; j++)
            for (int k = 0; k < n; k++)
                C[i, j] += A[i, k] * B[k, j];
    return C;
}

void PrintMatrix(string name, int[,] matrix, int rows, int cols)
{
    Console.WriteLine($"*** {name} ***");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}