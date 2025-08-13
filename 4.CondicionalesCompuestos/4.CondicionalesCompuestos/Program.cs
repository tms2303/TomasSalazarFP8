using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4.CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.*/

            int sueldo = 0;
            string nombre = "";
            Console.WriteLine();
            
                Console.WriteLine("ingrese el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese el sueldo");
                sueldo =Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //verdadera
                Console.WriteLine($"la persona{nombre}, debe abonar impuestos");
            }
            else
            {
                //falsa
                Console.WriteLine($"la persona{nombre}, no debe abonar impuestos");
            }

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”.*/

            int edad = 0;
            Console.WriteLine();

            Console.WriteLine("ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }
            else
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            //Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número.

            int num1 = 0;
            int num2 = 0;
            Console.WriteLine();

            Console.WriteLine("ingrese el primer numero");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2) 
            {
                Console.WriteLine(num1 + num2);
                Console.WriteLine(num1 - num2);
            }
            else
            {
                Console.WriteLine(num1 * num2);
                Console.WriteLine(num1 / num2);
            }
            /*Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares.
            Si el usuario se queda más de 3 noches se le aplica un porcentaje de descuento del 17 % y si no se aplica un porcentaje de descuento del 2 %.
Mostrar un mensaje con el monto total que debe pagar el cliente, sabiendo que el usuario indica cuántas noches se va a quedar en la hostería.*/


        }
    }
}
