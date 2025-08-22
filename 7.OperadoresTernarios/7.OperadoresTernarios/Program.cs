namespace _7.OperadoresTernarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario.Una persona mayor de edad tiene 18 años o más).

            /*int edad;
            Console.WriteLine("Ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine(edad >= 18 ? "la persona es mayor de edad" : "la persona es menor de edad");*/

            //Crear un algoritmo que permita ingresar 3 números enteros, y mostrar por pantalla cuál es el mayor

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("ingrese el numro 1");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numro 2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numro 3");
            num3 = Int32.Parse(Console.ReadLine());

            mayor = num1 > num2 
                ? (num1 > num3 ? num1 : num3)
                : (num2 > num3 ? num2 : num3);
            Console.WriteLine($"el numero mayot es: {mayor}");
        }
    }
}
