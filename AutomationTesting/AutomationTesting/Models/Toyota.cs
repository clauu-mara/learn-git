namespace AutomationTesting.Models
{
    public class Toyota : Car
    {
        //method overloading
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        //return types
        public static string Text()
        {
            return "text";
        }

        public static Audi AudiCar(Audi audi)
        {
            return new Audi
            {
                Model = audi.Model,
                Color = "Audi q8",
                Price = audi.Price
            };
        }

        public static object ObjectExercise()
        {
            return new object();
        }

        public static double DoubleTest()
        {
            return 123.45d + 456.32211d;
        }

        public static string CarName()
        {
            var car = new BMW
            {
                Color = "Blue",
                Name = "BMW car",
                Price = 12000,
                Model = "I8"
            };
            return car.Name ;
        }

        public static Car CarType() 
        {
            return new Audi();
        }

        public override void Check()
        {
            var testCaseState = "Failed";
            switch (testCaseState)
            {
                case "Passed":
                    {
                        Console.WriteLine("The case passed");
                        break;
                    }
                case "Failed":
                    {
                        Console.WriteLine("The case failed");
                        break;
                    }
                case "Inconclusive":
                    {
                        Console.WriteLine("The case inconclusive");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The case is not you sent");
                        break;
                    }
            }
        }
    }
}
