namespace AutomationTesting.Models
{
    public class FunctionsExercises
    {
       public static void GreetingFunction(string name)
       {
            Console.WriteLine("Hello: " + name);
       }
       public static void  FarewellFunction()
       {
            Console.WriteLine("Goodbye!");
       }
       public static void CountSpaces(string text)
       {
            int counter = 0;
            
            for (int i = 0; i <= text.Length -1; i++)
            {
                var letter = text.Substring(i, 1); // used to check every char from the string

                if (letter.Equals(" "))
                    counter++;
            }
            Console.WriteLine("Total spaces: " + counter);
       }

       public static void Sum()
       {
            int[] integerArray = new int[5];
            int sum = 0;

            Console.WriteLine("Enter 5 integers: ");
            for (int i = 0; i <= integerArray.Length - 1; i++)
            {
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(var number in integerArray)
            {
                sum += number;
            }

            Console.WriteLine("The sum is:" + sum);
       }

        public static int Double(int number)
        {
            return number * 2;
        }
    }
}
