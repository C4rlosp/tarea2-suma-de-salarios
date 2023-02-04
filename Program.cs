using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrreglo y matrices
            int[] edad = new int[] { 20, 22, 33 };
            float[] salarios = new float[] { 200, 300, 150 };
            string[] musicos = new string[] { "Ringo", "Paul", "John" };

            float totalSalarios = 0;

            Console.WriteLine(musicos.Length);
            //ciclo for
            for (int i = 0; i < musicos.Length; i++)
            {
                float IVA = salarios[i] * 0.13;
                totalSalarios += salarios[i];
                Console.WriteLine($"{musicos[i]} Edad: {edad[i]} Salario: {salarios[i]} IVA: {IVA} Total: {salarios[i] + IVA}");
            }
            //imprimimos la suma de los salarios
            Console.WriteLine($"Total de salarios: {totalSalarios}");

            Console.ReadLine();


        }
    }
}
