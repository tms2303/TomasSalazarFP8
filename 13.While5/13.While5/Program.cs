namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
            El algoritmo debe escribir en pantalla: 
            La cantidad de números introducidos que son mayores que 0 
            La cantidad de números introducidos menores que 0  
            La cantidad de números iguales a 0. */

            int contador;
            int mayores = 0;
            int menores = 0;
            int iguales = 0;
            int numeros;

            Console.WriteLine("ingrese la cantidad de numeros que vas a introducir");
            contador = Convert.ToInt32(Console.ReadLine());

            while (contador > 0) 
            {
                Console.WriteLine("ingrese un numero");
                numeros = int.Parse(Console.ReadLine());

                if (numeros == 0)
                {
                    iguales++;
                }
                if (numeros < 0)
                {
                    menores++;
                }
                if (numeros > 0)
                {
                    mayores++;
                }
                contador--;
            }

            Console.WriteLine($"Hay m (menores){menores}, M (Mayores){mayores}, Cero {iguales}");

        }
    }
}
