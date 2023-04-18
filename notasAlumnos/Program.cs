using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //varios alumnos, nota promedio

            string nombre, apellido;                                    
            int  nota, notaFinal;            
            List<int> listNotas = new List<int>();
            Dictionary<string, List<int>> dictionaryNotas = new Dictionary<string, List<int>>();
            ConsoleKeyInfo key;
            ConsoleKeyInfo k;

            do
            {
             Console.Write("Nombre alumno: ");
             nombre = Console.ReadLine();
             List<int> listaNotas= new List<int>();
            do
            {
                Console.Write("Nota: ");
                try
                {
                    nota = Convert.ToInt16(Console.ReadLine());                   
                }
                catch (Exception)
                {
                    break;                  
                }          
                
                listaNotas.Add(nota);                
                
                key = Console.ReadKey();

            } while (nota.GetType().Name == "Int32");
                       
            dictionaryNotas.Add(nombre,listaNotas);           

            Console.WriteLine("¿Desea cargar otro alumno?");            
            k = Console.ReadKey();

            } while (k.KeyChar != 13);

            Console.WriteLine(dictionaryNotas);
        }     
    }
}
