namespace _19.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En un grupo de 100 alumnos, desea 

            int edad = 0;
            int genero = 0;
            int mayorEdad = 0;
            int menorEdad = 0;
            int hombre = 0;
            int mujer = 0;
            int numeroEstudiantes = 0;
            int cantidad = 5;
            do
            {
                Console.WriteLine("Por favor ingrese la edad:");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Cual es su genero:");
                Console.WriteLine("1.Hombre 2.Mujer");
                genero = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    mayorEdad++;
                }
                else
                {
                    menorEdad++;
                }

                if (genero == 1)
                {
                    hombre++;
                }
                else
                {
                    mujer++;
                }
                numeroEstudiantes++;

            } while (numeroEstudiantes<cantidad);

            Console.WriteLine($"De los {cantidad} de estudiantes, {mayorEdad} son mayores de edad, {menorEdad} son menor de edad, {hombre} son hombres, {mujer} son mujeres");

        }
    }
}
