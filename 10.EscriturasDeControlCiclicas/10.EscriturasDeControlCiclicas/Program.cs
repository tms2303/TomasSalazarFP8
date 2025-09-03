namespace _10.EscriturasDeControlCiclicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int suma = 0;

            while (contador<=99)

            {
                suma += contador;
                Console.WriteLine($"{contador} - {suma}");
                contador += 2;
            }

            Console.WriteLine($"La suma de los numeros impares hasta el 99 es: {suma}");
        }
    }
}
