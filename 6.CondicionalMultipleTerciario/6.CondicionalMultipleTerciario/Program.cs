using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using System.Text;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        /*6. Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
        Si el día es martes o jueves, se realizará un descuento del 15% por la compra.
        Si el día es lunes o miércoles, se realizará un descuento del 10% por la compra.
        Si el día es viernes o sábado, se realizará un descuento del 20% por la compra.
        Si es domingo no se realiza descuento.
        Visualizar el día, el descuento y el total a pagar por la compra.*/
        static void Main(string[] args)
        {
            /*float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de la compra");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana: L:Lunes, M:Martes, X:Miercoles, J:Jueves, V:Viernes, S:Sabado, D:Domingo");
            dia = Convert.ToChar(Console.ReadLine());

            switch(dia)
            {
                case 'L':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");

                    break;
                case 'M':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                    break;
                case 'X':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miercoles, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");

                    break;
                case 'J':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");

                    break;
                case 'V':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");

                    break;
                case 'S':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sabado, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");

                    break;
                case 'D':
                    descuento = valorCompra * 0f;
                    Console.WriteLine($"Hoy es Domingo, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");

                    break;

                default:
                    Console.WriteLine("Debe ingresar un dia de la semana valido");
                    break;*/

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario*/

            float num1 = 0.0f;
            float num2 = 0.0f;
            float resultado = 0.0f;
            char operacion = ' ';
            Console.WriteLine($"Ingrese {num1} y {num2} ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese +:suma, -:resta, *:multiplicacion, /:division");
            operacion = Convert.ToChar(Console.ReadLine());

            switch(operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine($"");
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine($"");
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine($"");
                    break;
                case '/':
                    resultado = num1 / num2;
                    Console.WriteLine($"");
                    break;
                default:
                    Console.WriteLine("SYNTAXX ERROR");
                    break;

            }
        
        }    
    }
}
