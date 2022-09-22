using System;
using System.Linq;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES 
            String Nombre;
            float Nota;
            float Promedio;
            float Narriba = 0;
            float Nabajo = 0;
            String[] nombres = new string[5];
            float[] notas = new float[5];

            //BIENVENIDA
            Console.WriteLine("...BIENVENIDO...");

            //SOLICITUD DE DATOS 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante :");                
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del estudiante " + Nombre);
                Nota = float.Parse(Console.ReadLine());
                nombres[i]= Nombre;
                notas[i] = Nota;
                Console.WriteLine(" ");
            }

            //IMPRESION DE LOS DATOS ADQUIRIDOS
            Console.WriteLine(".............");
            Console.WriteLine("ESTUDIANTES INGRESADOS\n");
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Estudiante :" + nombres[i]);
                Console.WriteLine("Nota       :" + notas[i]);
                Console.WriteLine(".............\n");

            }
            

            //CALCULO DE PROMEDIO
            Promedio = notas.Sum();
            Promedio = Promedio / 5;

            Console.WriteLine("El ptomedio de las notas de los estudiantes es de :" + Promedio);
            Console.WriteLine(".............\n");

            //CALCULO DE LA NOTA MAS ALTA
            Console.WriteLine("La nota mas alta es de :" + notas.Max());
            Console.WriteLine(".............\n");

            //NOTAS POR ENCIMA Y POR DEBAJO DEL PROMEDIO
            for (int i = 0; i < 5; i++)
            {
                if  (notas[i] > Promedio)
                {
                    Narriba++;
                }
                else
                {
                    Nabajo++;
                }
            }
            Console.WriteLine("Notas por arriba de promedio: {0} \nNotas por debajo del Promedio {1}", Narriba,Nabajo);
            Console.WriteLine(".............\n");
            Console.Read();

        }
    }
}