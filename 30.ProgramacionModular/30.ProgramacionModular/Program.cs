namespace _30.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("MI nombre es Tomas");
            // MostrarMensajes("Tengo 18 años");
            //Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensaje($"Tengo {CalcularEdad(2025-2007)}");
        }

        //Modulo1

       static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la clase de Programacion Modular");
        }

        //Modulo2
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        
        //Modulo3
        static int CalcularEdad()
        {
            int edad;
            edad = 2025 - 2007;
            return edad;
        }

        //Modulo4

        static int CalcularEdad(int AñoActual, int AñoNacimiento)
        {
            return AñoActual - AñoNacimiento;
        }
    }
}
