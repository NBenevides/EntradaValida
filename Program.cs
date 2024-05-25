Console.Clear();

int numero = -1;

Console.WriteLine("--- Entrada Válida ---\n");


while (numero < 0 || numero > 9)
{
    Console.Write("\nDigite um número entre 1 e 9 (ou 0 para cancelar): ");
    numero = Convert.ToInt32(Console.ReadLine()!);
}

if(numero == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\nOperação cancelada.");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nVolte sempre.");
    Console.ResetColor();
}
else
{
    
    Console.Write("\nNúmero selecionado = ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{numero}\n");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Volte sempre.");
    Console.ResetColor();
}