Console.Clear();

string[][] digitos =
[
    [" _ ", "| |", "|_|"], // 0
    ["   ", "  |", "  |"], // 1
    [" _ ", " _|", "|_ "], // 2
    [" _ ", " _|", " _|"], // 3
    ["   ", "|_|", "  |"], // 4
    [" _ ", "|_ ", " _|"], // 5
    [" _ ", "|_ ", "|_|"], // 6
    [" _ ", "  |", "  |"], // 7
    [" _ ", "|_|", "|_|"], // 8
    [" _ ", "|_|", " _|"]  // 9
];

Console.Write("Digite o número da conta: ");
string conta = Console.ReadLine()!;

if (conta.Length != 9)
{
    Console.WriteLine("Digite exatamente 9 dígitos.");
    return;
}

for (int linha = 0; linha < 3; linha++)
{
    for (int i = 0; i < conta.Length; i++)
    {
        int numero = conta[i] - '0';

        Console.Write(digitos[numero][linha]);

    }

    Console.WriteLine();
}