namespace _22.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            le permitirá al usuario, introducir tantas calificaciones como así desee,
            en el momento en que seleccione que no desea continuar capturando
            calificaciones, el algoritmo debe presentar el promedio de las
            calificaciones capturadas previamente.*/

            /*float calificaciones = 0;
            int porcentaje = 0;
            int contador = 0;
            float suma = 0;
            string respuesta = "si";

            do
            {

                Console.WriteLine("Introdusca la calificacion del estudiante");
                calificaciones = float.Parse(Console.ReadLine());
                suma += calificaciones;
                contador++;
                Console.WriteLine("desea ingresar otra calificacion? (si/no)");
                respuesta = Console.ReadLine().ToLower();
             
            } while (respuesta == "si");

           if (contador>0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine($"el promedio de las calificaciones es: {promedio}");
            }
            else
            {
                Console.WriteLine("no se ingresaron mas calificaciones");
            }*/

            /*Se requiere un algoritmo para mostrar por pantalla los divisores de un 
             número ingresado por teclado. 
             Tener en cuenta que dados dos números enteros a y b, se dice que b es 
             divisor de a si se cumple que al efectuar una división entera a/b el 
             residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
             una división de dos números. 
             Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
             2, 1 que son los divisores del número 6. */

            /*int numero_A = 0;
            int divisor = 0;

            Console.WriteLine("ingrese un numero entero");
            numero_A = int.Parse(Console.ReadLine());

            for(int numero_B = 1; numero_B <= numero_A; numero_B++)
            {
                if (numero_A % numero_B == 0)
                {
                    divisor = numero_B;

                    Console.WriteLine($"{divisor} es divisor de {numero_A}");
                }
            }*/

            /*Dados dos números enteros ingresados por teclado: b que es la base y 
            e que es el exponente, se requiere calcular el resultado de la 
            potenciación.  
            Ejemplo: b=2, e=5  25=2*2*2*2*2= 32 
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la 
            potenciación correspondiente, hasta que el usuario ingrese por teclado 
            el carácter de escape ‘n’ */

            int base_num = 0;
            int exponente = 0;
            int resultado = 1;
            string escape = "n";

            do {

                Console.WriteLine("ingrese el numero base");
                base_num = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese otro numero para que sea el exponente");
                exponente = int.Parse(Console.ReadLine());
                Console.WriteLine("Desea salir? s/n");
                escape = Console.ReadLine().ToLower();

                for (int contador = 1; contador<= exponente; contador++)
                {
                    resultado = resultado * base_num;
                }

            } while(escape == "n");

            Console.WriteLine($"el resultado de {base_num} elevado a {exponente} es: {resultado}");
        }
    }
}
