Console.WriteLine("Bienvenido al juego de adivinanza de números!");
Console.WriteLine("Un número aleatorio entre 1 y 15 ha sido generado.");

Random rnd = new Random();
int numeroAleatorio = rnd.Next(1, 16);
int intentos = 3;

Console.Write("Por favor, introduzca su primer intento para adivinar el número en cuestión: ");
int numeroIntento = Convert.ToInt32(Console.ReadLine());

while (intentos > 0)
{
    if (numeroIntento == numeroAleatorio)
    {
        Console.WriteLine("¡Felicidades, ha adivinado el número!");
        return;
    }
    else if (numeroIntento < numeroAleatorio)
    {
        Console.WriteLine("El número es mayor que {0}.", numeroIntento);
    }
    else
    {
        Console.WriteLine("El número es menor que {0}.", numeroIntento);
    }

    intentos--;
    if (intentos > 0)
    {
        Console.Write("Inténtelo otra vez ({0} intentos restantes): ", intentos);
        numeroIntento = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Has agotado todos sus intentos. El número era {0}.", numeroAleatorio);