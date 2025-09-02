using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar un mensaje
            Console.WriteLine("Bienvenido a C#");
            //--Definir variables--
            int a, b, suma;

            //--Entrada de Datos--
            //Solicitando datos
            Console.WriteLine("Ingrese el primer numero");
            //Guardar los datos
            a= Convert.ToInt32(Console.ReadLine());
            //Solicitando datos
            Console.WriteLine("Ingrese el segundo numero");
            //Guardar los datos
            b = Convert.ToInt32(Console.ReadLine());

            //--Proceso--
            suma = a + b;

            //--Salida Datos--
            Console.WriteLine("La suma es: "+suma);
            Console.WriteLine($"La suma de {a} + {b} = {suma}");

            //Pasuar para mostrar Resultados
            Console.ReadKey();
        }
    }
}
