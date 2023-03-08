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
                    Console.Write(integerArray[i] + " "); // check - maybe there is a method that I can use for that
                }
            }

            public static void SearchForEvenNumbers()
            {
                int[] integerArray = new int[10];
                Console.WriteLine("Enter 10 integers: ");
                for (int i = 0; i <= integerArray.Length - 1; i++)
                {
                    integerArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                for(int i = 0; i <= integerArray.Length - 1; i++)
                {
                    if (integerArray[i] % 2 == 0)
                        Console.Write(integerArray[i] + " ");
                }
            }

            public static void ArithmeticMeanOfThePositiveAndNegativeNumbers()
             {
                 int[] integerArray = new int[10];

                 Console.WriteLine("Enter 10 integers: ");
                 for (int i = 0; i <= integerArray.Length - 1; i++)
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

                 Console.WriteLine("Average for positive numbers: " + positiveNumbers / lengthP);
                 Console.WriteLine("Average for negative numbers: " + negativeNumbers / lengthN);
             }
            public static void BubbleSortMethod()
            {
                int[] integerArray = new int[10];

                Console.WriteLine("Enter 10 integers: ");
                for (int i = 0; i <= integerArray.Length - 1; i++)
                {
                    integerArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                int aux = 0;

                for (int i = 0; i < integerArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < integerArray.Length; j++)
                        if (integerArray[i] > integerArray[j])
                        {
                            aux = integerArray[i];
                            integerArray[i] = integerArray[j];
                            integerArray[j] = aux;
                        }
                }

                Console.WriteLine("The array is: ");
                for (int i = 0; i < integerArray.Length; i++)
                    Console.Write(integerArray[i] + " ");
            }
    }
}