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
        private string nombre;
        private int edad;
        private double promedio;

        public Estudiante(string nom, int ed, double prom)
        {
            this.nombre = nom;
            this.edad = ed;
            this.promedio = prom;
        }

        public string GetNombre() { return nombre; }
        public int GetEdad() { return edad; }
        public double GetPromedio() { return promedio; }

        public void MostrarDatos()
        {
            Console.WriteLine($"\n{nombre.ToUpper()}");
            Console.WriteLine($"> Edad: {edad}");
            Console.WriteLine($"> Promedio: {promedio:F2}");
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
            if (estudiantes == null || estudiantes.Length == 0)
            {
                Console.WriteLine("No hay estudiantes registrados");
                return;
            }

            foreach (Estudiante e in estudiantes)
            {
                e.MostrarDatos();
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
