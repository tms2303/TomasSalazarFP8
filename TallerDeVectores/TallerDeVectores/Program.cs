namespace TallerDeVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
            encuentre y muestre el valor máximo y mínimo de los números ingresados. */

            /*int[] vector; //decalarando

            vector = new int[15]; //inicializando
            int mayor=0;
            int menor=0;

            for (int i  = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero entero para la posicion {i + 1}, con indice {i}");
                vector[i] = int.Parse(Console.ReadLine());

                if (i==0)
                {
                    mayor = vector[i];
                    menor = vector[i];
                }
                else
                {
                    if (vector[i]>mayor)
                    {
                        mayor = vector[i];
                    }
                    if (vector[i]<menor)
                    {
                        menor = vector[i];
                    }
                }
            }

            Console.Clear();

            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " | ");
            }

            Console.WriteLine($"\nEl numero mayor es: {mayor}, y el numero menor es:{menor}");*/

            /*Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el 
            orden de los elementos del vector. Se deben mostrar lo dos vectores. */

            char[] caracter;
            char[] CaracterInvertido;
            int cantidad=0;

            Console.WriteLine("Ingrese la cantidad de caracteres que desea ingresar");
            cantidad = int.Parse(Console.ReadLine());
            caracter = new char[cantidad];
            CaracterInvertido = new char[cantidad];

            for (int i=0; i<caracter.Length; i ++)
            {
                Console.WriteLine($"Ingrese el caracter para la posicion {i + 1}, con indice {i}");
                caracter[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < CaracterInvertido.Length; i++)
            {
                CaracterInvertido[i] = caracter[caracter.Length - 1 -i];
            }
            Console.Clear();

            for (int i = 0; i<caracter.Length; i++)
            {
                Console.Write(caracter[i] + " | ");
            }
            for (int i =0; i<CaracterInvertido.Length; i++)
            {
                Console.Write(caracter[i] + " | ");
            }
            
        }
    }
}
