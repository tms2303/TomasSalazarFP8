namespace _14.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.*/

            int rango = 0;
            int contadorPares = 0;
            int contador = 1;

            Console.WriteLine("ingrese el rango a evaluar");
            rango = int.Parse(Console.ReadLine());

            while (contador<=rango)
            {
                if (contador % 2 == 0) // % = residuo o divisor

                {
                    contadorPares++;
                }

                contador++;
            }

            Console.WriteLine($"la cantidad de numeros pares de 1 hasta {rango} es: {contadorPares}");
        }
    }
}
