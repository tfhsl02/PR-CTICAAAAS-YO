using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    class Estudiante
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double promedio { get; set; }

        public Estudiante(string nom, int ed, double prom)
        {
            nombre = nom;
            edad = ed;
            promedio = prom;
        }
    }
    class Informacion
    {
        private Estudiante[] estudiantes;
        public void RegistrarEstudiante()
        {
            Console.WriteLine("\n--DATOS DEL ESTUDIANTE--");
            Console.Write("Cantidad de estudiantes a ingresar:");
            int cantidad = int.Parse(Console.ReadLine());
            double SumaProm = 0;
            double promTotal = 0;
            estudiantes= new Estudiante[cantidad];
            for (int i= 0; i< cantidad; i++)
            {
                Console.WriteLine($"\n ESTUDIANTE {i + 1} ");
                Console.Write("> Nombre: ");
                string nom= Console.ReadLine();
                Console.Write("> Edad: ");
                int ed= int.Parse(Console.ReadLine());
                Console.Write("> Promedio: ");
                double prom= double.Parse(Console.ReadLine());
                estudiantes[i]= new Estudiante(nom,ed,prom);

                SumaProm += prom;
                promTotal = SumaProm / cantidad;
            }
            Console.Write($"> Promedio total de todos los estudiantes: {promTotal:F2}");
        }
        public void MostrarResumen()
        {
            foreach (Estudiante e in estudiantes)
            {
                Console.WriteLine($"\n {e.nombre.ToUpper()}");
                Console.WriteLine($"> Edad: {e.edad}");
                Console.WriteLine($"> Promedio: {e.promedio}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Informacion e= new Informacion();
            int opcion;
            do
            {
                Console.WriteLine("\n-- MENÚ DE ESTUDIANTES --");
                Console.WriteLine("\n1. Registro del estudiante" +
                                  "\n2. Mostrar Resumen" +
                                  "\n3. Salir del promagrama");
                Console.WriteLine("\nIngrese una opción:");
                opcion= int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        e.RegistrarEstudiante();break;
                    case 2:
                        e.MostrarResumen();break;
                    case 3:
                        Console.WriteLine("Saliendo del programa!!...");break;
                    default:
                        Console.WriteLine("Ingrese una opción válida...");break;
                }
            } while (opcion != 3);
        }
    }
}
