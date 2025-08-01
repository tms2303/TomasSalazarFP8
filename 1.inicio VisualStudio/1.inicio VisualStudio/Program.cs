using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.inicio_VisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion e inicializacion de variables
            string nombre ="Tomas";
            const string iva = "19%";
            string apellidos = "Salazar Arroyave";
            Console.Write(nombre+" Bienvenido al curso de fundamentos programacion\n");
            nombre = "Roman";
            //iva="20%"; no se puede cambiar el valor por ser una constante
            Console.Write("\t" + nombre + "" + apellidos + "" + iva);
            Console.ReadKey();
        }
    }
}
