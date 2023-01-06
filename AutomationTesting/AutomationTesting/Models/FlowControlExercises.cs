namespace AutomationTesting.Models
{
    public class FlowControlExercises
    {
        public static void OperationOnTwoNumbersIf()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operator:");
            var operation = Console.ReadLine();

            if (operation.Equals("+"))
                Console.WriteLine(firstNumber + " " + operation + " " + secondNumber + " = " + (firstNumber + secondNumber));
            else if (operation.Equals("-"))
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber - secondNumber}");
            else if (operation.Equals("*"))
                Console.WriteLine(firstNumber + " " + operation + " " + secondNumber + " = " + (firstNumber * secondNumber));
            else if (operation.Equals("/"))
                Console.WriteLine(firstNumber + " " + operation + " " + secondNumber + " = " + (firstNumber / secondNumber));
            else
                Console.WriteLine("Unrecognized character");
        }

        public static void OperationOnTwoNumbersSwitch()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operator:");
            var operation = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case "/":
                    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber / secondNumber}");
                    break;

                default:
                    Console.WriteLine("Unrecognized character");
                    break;
            }
        }
        public static void CheckIfNumberIsPositive()
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());

            if(number > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative");
        }
        public static void  GreatestNumber()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                Console.WriteLine(firstNumber);
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                Console.WriteLine(secondNumber);
            else
                Console.WriteLine(thirdNumber);
        }
        public static void MultiplyNumberByTenUsingWhile()
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                Console.WriteLine(10 * number);
                number = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void MultiplyNumberByTenUsingDoWhile()
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(10 * number);
                number = Convert.ToInt32(Console.ReadLine());
            } while (number > 0);
        }
        public static void RangeOfNumbers()
        {
            Console.WriteLine("Enter the first number for the interval:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number for the interval:");
            var lastNumber = Convert.ToInt32(Console.ReadLine());

            for(int i = firstNumber; i<=lastNumber;i++)
                Console.Write(i + " ");
        }
        public static void Sum()
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            do
            {
                sum += number;
                Console.WriteLine(sum);
                number = Convert.ToInt32(Console.ReadLine());
            } while (number != 0);
            Console.WriteLine("Finished");
        }
        public static void NumberRepeated()
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an amount:");
            var amount = Convert.ToInt32(Console.ReadLine());
            for(var i = 1; i <=amount;i++)
                Console.Write(number);
        }
        //TODO
        public static void AccessControl()
        {
            string username, password;
            var attempts = 0;

            do
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (!(username.Equals(12)) || !(password.Equals(1234)))
                {
                    Console.WriteLine("Login failed");
                    attempts++;
                }
                else
                    Console.WriteLine("Login successful");

            } while ((attempts < 3) || (username.Equals(12) && password.Equals(1234)));
               
        }
        public static void StudentsGarde()
        {
            Console.WriteLine("Enter a number:");
            var grade = Convert.ToInt32(Console.ReadLine());

            switch(grade)
            {
                case 10:
                    Console.WriteLine("A+");
                    break;
                case 9:
                    Console.WriteLine("A");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("B");
                    break;
                case 6:
                    Console.WriteLine("C");
                    break;
                case 5:
                    Console.WriteLine("E");
                    break;

                default:
                    Console.WriteLine("F");
                    break;
            }
        }
        public static void RepetitiveStructures()
        {
            Console.WriteLine("Enter the first number for the interval:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number for the interval:");
            var lastNumber = Convert.ToInt32(Console.ReadLine());

            for(int i=firstNumber; i<=lastNumber; i++)
                Console.Write(i);

            Console.WriteLine();

            var k = firstNumber;
            while(k <=lastNumber)
            {
                Console.Write(k);
                k++;
            }
            Console.WriteLine();

            var j = firstNumber;
            do
            {
                Console.Write(j);
                j++;
            } while (j <= lastNumber);
        }
        public static void CharAlphabet()
        {
            for(char i='A';i<='Z';i++)
                Console.Write(i + " ");
        }

        public static void ProductOfANumber()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            int multiplication = 0;

            int i = 0;
            while(i < secondNumber)
            {
                multiplication = multiplication + firstNumber;
                i++;
            }

            Console.Write(multiplication);
        }

        public static void OddNumbersInDescending()
        {
            Console.WriteLine("Enter the first number for the interval:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number for the interval:");
            var lastNumber = Convert.ToInt32(Console.ReadLine());

            for(int i= firstNumber;i>=lastNumber;i--)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }

        public static void GiveChange()
        {
            Console.WriteLine("Enter total amount of money you have in the cash register:");
            var totalAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter integer with the purchase value:");
            var purchaseValue = Convert.ToInt32(Console.ReadLine());

            var change = totalAmount - purchaseValue;

            while (change >= 100)
            {
                Console.Write(" 100 ");
                change -= 100;
            }

            while (change >= 50)
            {
                Console.Write(" 50 ");
                change -= 50;
            }

            while (change >= 20)
            {
                Console.Write(" 20 ");
                change -= 20;
            }

            while (change >= 10)
            {
                Console.Write(" 10 ");
                change -= 10;
            }

            while (change >= 5)
            {
                Console.Write(" 5 ");
                change -= 5;
            }

            while (change >= 2)
            {
                Console.Write(" 2 ");
                change -= 2;
            }

            while (change >= 1)
            {
                Console.Write(" 1 ");
                change -= 1;
            }

        }
  
        public static void ConditionalOperator()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNumber > 0 ? "A is positive" : "A is not positive" );
            Console.WriteLine(secondNumber > 0 ? "B is positive" : "B is not positive");
            Console.WriteLine((firstNumber > secondNumber) && (secondNumber >  0 )? "Both are positive" : "Not both are positive");
        }

        public static void ConditionalOperatorNested()
        {
            Console.WriteLine("Enter first number:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            int counter = (firstNumber > 0) && (secondNumber > 0) ? 2 : (firstNumber > 0) || (secondNumber > 0) ? 1 : 0;
            Console.WriteLine(counter);
        }

    }
}
