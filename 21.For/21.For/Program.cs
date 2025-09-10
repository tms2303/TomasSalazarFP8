namespace _21.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int i =0; i <=5; i++)
            {
                acumulador += i;
            }
            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");
        }
    }
}
