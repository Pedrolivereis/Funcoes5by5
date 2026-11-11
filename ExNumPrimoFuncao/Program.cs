void ValidacaoPrimo(int numero)
{
    int contador = 0;
    for (int i = 2; i <= numero; i++)
    {
        contador = 0;
        for (int j = i; j >= 2; j--)
        {
            if (i % j == 0)
            {
                contador++;
            }
            if (contador > 1)
            {
                break;
            }
        }
        if (contador <= 1)
        {
            Console.WriteLine(i);
        }
    }
}
Console.WriteLine("Informe um numero:");
ValidacaoPrimo(int.Parse(Console.ReadLine()));