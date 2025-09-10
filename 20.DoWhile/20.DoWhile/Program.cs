namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
             El número de partidos perdidos  
             El número de partidos empatados  
             El número de partidos ganados  
             El porcentaje de partidos perdidos  
             El porcentaje de partidos empatados  
             El porcentaje de partidos ganados */
           
            int partidosGanados = 0;
            int partidosPerdidos = 0;
            int partidosEmpatados = 0;
            int partidosTotales =3;
            int partidos = 0;

            do
            {
                Console.WriteLine("ingrese 1 si gano el partido, 2 si lo perdio y 3 si lo empato");
                partidos = int.Parse((Console.ReadLine()));

                if (partidos==1)
                {
                    partidosGanados++;
                }
                if (partidos == 2)
                {
                    partidosPerdidos++;
                }
                if (partidos == 3)
                {
                    partidosEmpatados++;
                }
              
            } while (partidos<partidosTotales);

            Console.WriteLine($"El porcentaje de partidos ganados es: {partidosGanados*100/partidos}, " +
                $"el porcentaje de partidos perdidos es: {partidosPerdidos*100/partidos}, " +
                $"y el porcentaje de los  partidos empatados es: {partidosEmpatados*100/partidos}");
        }
    }
}
