using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Models
{
    public class ArrayExercises
    {
            public static void DisplayArrayInReversOrder()
            {
                int[] integerArray = new int[5];
                Console.WriteLine("Enter 5 integers: ");
                for (int i = 0; i <= 4; i++)
                {
                    integerArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = integerArray.Length - 1; i >= 0; i--)
                {
                    Console.Write(integerArray[i] + " ");
                }
            }

            public static void SearchForEvenNumbers()
            {
                int lenghtOfTheArray = 10;
                int[] integerArray = new int[lenghtOfTheArray];
                Console.WriteLine("Enter 10 integers: ");
                for (int i = 0; i <= lenghtOfTheArray - 1; i++)
                {
                    integerArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                for(int i=0; i<= integerArray.Length-1; i++)
                {
                    if (integerArray[i] % 2 == 0)
                        Console.Write(integerArray[i] + " ");

                }
            }

            public static void ArithmeticMeanOfThePositiveAndNegativeNumbers()
             {
                 int lenghtOfTheArray = 10;
                 int[] integerArray = new int[lenghtOfTheArray];

                 Console.WriteLine("Enter 10 integers: ");
                 for (int i = 0; i <= lenghtOfTheArray - 1; i++)
                 {
                     integerArray[i] = Convert.ToInt32(Console.ReadLine());
                 }

                 float positiveNumbers = 0.0f, negativeNumbers = 0.0f;
                 int lengthP = 0, lengthN = 0;

                 foreach (var number in integerArray)
                 {
                     if (number > 0)
                     {
                         positiveNumbers += number;
                         lengthP++;
                     }

                     if (number < 0)
                     {
                         negativeNumbers += number;
                         lengthN++;
                     }
                 }

                 var positiveAverage = positiveNumbers / lengthP;
                 var negativeAverage = negativeNumbers / lengthN;
                 Console.WriteLine("Average for positive numbers: " + positiveAverage);
                 Console.WriteLine("Average for negative numbers: " + negativeAverage);
             }
            public static void BubbleSortMethod()
            {
                int lenghtOfTheArray = 10;
                int[] integerArray = new int[lenghtOfTheArray];

                Console.WriteLine("Enter 10 integers: ");
                for (int i = 0; i <= lenghtOfTheArray - 1; i++)
                {
                    integerArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                int aux = 0;

                for (int i = 0; i < lenghtOfTheArray - 1; i++)
                {
                    for (int j = i + 1; j < lenghtOfTheArray; j++)
                        if (integerArray[i] > integerArray[j])
                        {
                            aux = integerArray[i];
                            integerArray[i] = integerArray[j];
                            integerArray[j] = aux;
                        }
                }

                Console.WriteLine("The array is: ");
                for (int i = 0; i < lenghtOfTheArray; i++)
                    Console.Write(integerArray[i] + " ");
            }
    }
}