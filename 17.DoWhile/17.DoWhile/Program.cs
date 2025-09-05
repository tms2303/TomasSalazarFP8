namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo que genere y calcule la suma de los primeros 5 numerods enteros positivos

            /*int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador <= 5);

            Console.WriteLine($"la suma de los cinco numeros es: {acumulador}");*/

            /*Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 
             * 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. */

            int numero = 0;
            int multiplicacion = 1;
            string respuesta = " ";

            do
            {

                Console.WriteLine("Por favor ingrese un numero");
                numero = Int32.Parse((Console.ReadLine()));

                do
                {
                    Console.WriteLine($"{numero} X {multiplicacion} = {numero * multiplicacion}");
                    multiplicacion++;
                } while (multiplicacion <= 10);

                multiplicacion = 1;
                Console.WriteLine("Quiere generar otra tabla de multiplicacion: s:si - n:no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");
        }
    }
}
