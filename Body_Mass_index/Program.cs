using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_Mass_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of persons: ");
            int n = int.Parse(Console.ReadLine());
            double[,] persons = new double[n, 2];
            double[] result = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter weight for person in kilograms: ");
                persons[i, 0] = double.Parse(Console.ReadLine());
                Console.Write("Enter height for person in meters: ");
                persons[i, 1] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                result[i] = persons[i, 0] / Math.Pow(persons[i, 1], 2);
                if (result[i] < 18.5)
                {
                    Console.Write("under ");
                }
                else if ((result[i] >= 18.5) && (result[i] < 25))
                    {
                        Console.Write("normal ");
                    }
                    else if ((result[i] >= 25) && (result[i] < 30))
                        {
                            Console.Write("over ");
                        }
                        else Console.Write("obese ");
            }
            Console.ReadKey();
        }
    }
}
