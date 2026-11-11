void Hello(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
Hello("Pedro");

bool EPrimo(int numero)
{
    if (numero <= 1)
    {
        return false;
    }
    int contador = 0;
    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }
    }
    if (contador > 2)
    {
        return false;
    }
    else
    {
        return true;
    }

}

Console.WriteLine("Informe o numero desejado: ");
bool primo = EPrimo(int.Parse(Console.ReadLine()));
if (primo)
{
    Console.WriteLine("O numero informado é primo");
}
else
{
    Console.WriteLine("O numero informado não é primo");
}
