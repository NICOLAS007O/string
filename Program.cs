// Declaração de variáveis
string nomeDigitado;
string sobrenomeDigitado;
// string nomeMaiusculas;
string nomeLeet;

Console.Clear();

Console.WriteLine("--- Dados Pessoais ---");

Console.Write("     Nome: ");
nomeDigitado = Console.ReadLine()!.ToUpper(); // Atribuição

nomeLeet = nomeDigitado
            .Replace("A", "4")
            .Replace("I", "1")
            .Replace("E", "3");

// nomeMaiusculas = nomeDigitado.ToUpper();

Console.Write("Sobrenome: ");
sobrenomeDigitado = Console.ReadLine()!;

Console.WriteLine($"Boa noite, {nomeLeet} {sobrenomeDigitado.ToUpper()}!"); // Interpolação

Console.Write("Pressione uma tecla para continuar...");
Console.ReadKey(true);
