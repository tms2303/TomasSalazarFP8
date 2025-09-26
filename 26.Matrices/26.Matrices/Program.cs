namespace _26.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2]; // matriz es 2*2
            string[,] nombres = new string[2, 3]; //rango=r posicion

            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;

            string[,] apellidos = //otra forma de inicializar matrices
            {
              {"Juan","Escobar"},
              {"Miguel","Alberto"},
              {"Juanes","Jaramillo"}
            };
            //recuperar datos de la matriz
            Console.WriteLine(apellidos[1, 1]);

            //Recorrer Matrices - Almacenar Datos

            char[,] caracteres = new char[3, 2];

            for (int  i = 0;  i < 2; i++) //i es el contador y este for recorre las filas
            {
                for (int j = 0; j < 2; j++)// j esta dentro del contexto de i entoces i no se puede volver a usar
                                           //recorre las columnas de cada una de las filas
                {
                    Console.WriteLine($"Ingrese el caracter para la posicion con indices {i},{j}:");
                    caracteres[i, j] = char.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < caracteres.GetLength(0); i++) //.GetLength(0) devuelve numero de filas
            {
                for(int j = 0; j < caracteres.GetLength(1); j++) //y el GreLength(1) devuelve el numero de columnas
                {
                    Console.WriteLine($"Caracter posicion {i},{j}: {caracteres[i, j]} |");
                }
                Console.WriteLine();
            }

            //Rango de la matriz
            Console.WriteLine(caracteres.Length);
        }
    }
}
