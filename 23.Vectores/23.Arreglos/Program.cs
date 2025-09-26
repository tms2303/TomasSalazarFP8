namespace _23.Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales
            //Vectores

            /* int[] numeros=new int[5]; //El vector numeros tiene 5 posiciones, el rango es 4 pq el int inicial que es 1, se resta
                                       //con el new int que es 5

             string[] nombres = new string[4]; //asigna valores a las posiciones

             numeros[0] = 20;
             numeros[1] = 15;
             numeros[2] = 5;
             numeros[3] = 30;
             numeros[4] = 45;*/

            //el numeros 5 no se puede hacer, pq el rango es de 0 a 4

            /*int[] numeros1 = new int[] { 5, 12, 4, 7, 9, 21 }; //Otras formas de iniciar un arreglo (en vectores)
            int[] numeros2 = { 5, 12, 4, 7, 9 };*/

            //se puede recorrer el vector para llenarlo de datos o para recuperarlos

            /*char[] caracter = new char[4];

            /*for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posicion{i+1}, con indice {caracter[i]}:");
                caracter[i] = Convert.ToChar(Console.ReadLine());
            }*/

            /*for (int i = 0; i < caracter.Length; i++) //.Length devuelve el rango del vector
            {
                Console.WriteLine(caracter[i] + " | ");
            }*/

            string[] nombres = new string[4];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese 4 nombres");
                nombres[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i=0; 1<nombres.Length; i++)
            {
                Console.WriteLine($"los nombres ingresados fueron:{nombres[i]}");
            }
        }
        
    }
}
