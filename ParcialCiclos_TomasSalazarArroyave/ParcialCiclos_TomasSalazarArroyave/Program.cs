namespace ParcialCiclos_TomasSalazarArroyave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa que calcule la nota final de un grupo de 10 alumnos a 
             * partir de sus evaluaciones. La calificación final se obtiene aplicando los siguientes porcentajes:
            Práctica: 10%
            Problemas: 50%
            Teórica: 40%
            Las notas de cada evaluación estarán en un rango de 0 a 10.
            El programa debe realizar, para cada alumno, las siguientes acciones:
            Solicitar el nombre del alumno.
            Ingresar las tres calificaciones correspondientes a práctica, problemas y teórica.
            Calcular la nota final ponderada según los porcentajes establecidos.
            Determinar si el alumno aprueba (nota final > 6) o reprueba (nota final ≤ 6).
            Mostrar en pantalla el nombre del alumno, la nota final y el resultado (aprobado o reprobado).*/

            double notaPractica, notaProblemas, notaTeorica, notaFinal;
            string nombreAlumno, resultado;


            for (int i = 1; i<=10; i++) 
            {
                Console.WriteLine($"Ingrese el nombre del alummno {i}");
                nombreAlumno = Console.ReadLine();

                Console.WriteLine("Ingrese la nota de practica");
                notaPractica = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la nota de problmas");
                notaProblemas = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la nota teorica");
                notaTeorica = Convert.ToDouble(Console.ReadLine());

                notaFinal = (notaPractica * 0.1) + (notaProblemas * 0.5) + (notaTeorica * 0.4);

                if (notaFinal > 6)
                {
                    resultado = "aprobado";
                    Console.WriteLine($"El alumno {nombreAlumno} tiene una nota final de {notaFinal} y ha {resultado}");
                }
                else if (notaFinal <= 6)
                {
                    resultado = "reprobado";
                    Console.WriteLine($"El alummno {nombreAlumno} tiene una nota final de {notaFinal} y ha {resultado}");
                } 
            }

        }
    }
}
