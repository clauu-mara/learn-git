using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Models
{
    public class DataTypesExercises
    {
        public static void ReverseChar()
        {
            Console.WriteLine("Insert 3 letters");
            Console.WriteLine("Insert first letter");
            var firstLetter = Console.ReadLine();
            Console.WriteLine("Insert second letter");
            var secondLetter = Console.ReadLine();
            Console.WriteLine("Insert third letter");
            var thirdLetter = Console.ReadLine();

            Console.WriteLine(thirdLetter + " " + secondLetter + " " + firstLetter);
        }

        public static void CheckVowels()
        {
            Console.WriteLine("Insert a letter:");
            char letter = Convert.ToChar(Console.ReadLine());    
            
            switch(letter)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;

                default: Console.WriteLine("Not a vowel");
                    break;
            }

        }
        //TODO 
       /* public static void CheckIfEnteredTextIsNumber()
        {
            Console.WriteLine("Enter text:");
            var itIsANumber = Console.ReadLine();
            if (Convert.ToInt32(itIsANumberr)
                Console.WriteLine("It is a number");
           else
                Console.WriteLine("It is not a number");
        }*/
       public static void CheckIfTwoNumbersAreEvenOrOdd()
        {
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter first number");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            bool evenNumbers = false;

            if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
                evenNumbers = true;
            else if (firstNumber % 2 != 0 && secondNumber % 2 == 0)
                evenNumbers = false;
            else if (firstNumber % 2 == 0 && secondNumber % 2 != 0)
                evenNumbers = false;
            else
                evenNumbers = false;

            Console.WriteLine(evenNumbers);
        }
        public static void ConvertIntegerToBinaryAndHexadecimal()
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Binary:" + Convert.ToString(number,2));
                Console.WriteLine("Hexadecimal:" + number.ToString("X"));

                number = Convert.ToInt32(Console.ReadLine());

            } while (number != 0);
        }
        public static void HexadecimalMatrix()
        {
            for (var i = 0; i < 16; i++)
            {

                for (var j = 0; j < 16; j++)
                {
                    Console.Write(i.ToString("x") + j.ToString("x") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
