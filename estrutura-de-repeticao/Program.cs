// Estrutura de Repeticao while
Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 101);
int contador = 0;
Console.WriteLine($"Número Alvo: {numero}");
// Loop que incrementa o contador ateele atingir o numero alvo
while (contador <= numero)
{
    Console.WriteLine($"Contador: {contador}.");
    contador++;
}
Console.WriteLine($"Contador antingiu o numero alvo: {contador}");
