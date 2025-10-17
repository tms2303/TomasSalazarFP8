using System.Runtime.Serialization.Formatters;

namespace Parcial_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Creación de la matriz:
            Utilice una matriz de 6 columnas por 6 filas (1 fila para encabezados y 5 filas para datos de estudiantes).
            La primera fila debe contener los encabezados de las columnas, en el siguiente orden:
            | Nombre del Estudiante | Grado | Nota Parcial 1 | Nota Parcial 2 | Examen Final | Nota Final |
            Ingreso de datos:
            Para cada uno de los 5 estudiantes, el programa debe solicitar por teclado:
            Nombre completo del estudiante.
            Grado (solo se permiten los grados: 6°, 7°, 8°, 9°). Validar la entrada.
            Nota del Parcial 1 (valor decimal entre 0.0 y 5.0). Validar la entrada.
            Nota del Parcial 2 (valor decimal entre 0.0 y 5.0). Validar la entrada.
            Nota del Examen Final (valor decimal entre 0.0 y 5.0). Validar la entrada.
            Calcular la Nota Final como el promedio de las tres notas (Parcial 1, Parcial 2 y Examen Final) .
            Visualización de la matriz:
            Una vez ingresados todos los datos, mostrar en pantalla la matriz completa con los encabezados y los datos de cada estudiante.
            Análisis de calificaciones:
            Determinar y mostrar en pantalla:
            El nombre del estudiante con la mayor nota final.
            Consideraciones adicionales:
            La matriz será una mezcla de texto y números, por lo tanto, se recomienda tratar los datos de la matriz, como tipo string y convertir las notas a tipos numéricos para realizar los cálculos.
            Use validación de entrada para garantizar que los datos del usuario cumplan con los requisitos establecidos.*/



            string estudiante;
            int grado;
            double notaParcial1, notaParcial2, notaExamenFinal, notaFinal;

            string[,] Matriz = new string[6, 6];
            Matriz[0, 0] = "Nombre del estudainte";
            Matriz[0, 1] = "Grado";
            Matriz[0, 2] = "Nota parcial 1";
            Matriz[0, 3] = "Nota parcial 2";
            Matriz[0, 4] = "Examen final";
            Matriz[0, 5] = "Nota Final";

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Ingrese el nombre del estudiante:");
                estudiante = Console.ReadLine();
                Matriz[i,0] = estudiante;

                  Console.WriteLine($"Ingrese el grado del estudiante:");
                  grado = int.Parse(Console.ReadLine());
                Matriz[i,1] = grado.ToString();

                Console.WriteLine($"Ingrese la nota del parcial 1:");
                  notaParcial1 = double.Parse(Console.ReadLine());
                Matriz[i,2] = notaParcial1.ToString();

                Console.WriteLine($"Ingrese la nota del parcial 2:");
                  notaParcial2 = double.Parse(Console.ReadLine());
                Matriz[i,3] =notaParcial2.ToString();

                Console.WriteLine($"Ingrese la nota del examen final:");
                  notaExamenFinal = double.Parse(Console.ReadLine());
                Matriz[i,4] = notaExamenFinal.ToString();

                notaFinal = (notaParcial1 + notaParcial2 + notaExamenFinal) / 3;
                Matriz[i,5] = notaFinal.ToString();
            }

            for (int i=0; i<6; i++)
            {
                for (int j=0; j<6; j++)
                {
                    Console.Write(Matriz[i, j] + " | ");
                }
                Console.WriteLine();
            }  
               
        }
    }
}
