namespace AutomationTesting
{
    public class Toyota
    {
        //method overloading
        public int Add (int num1, int num2)
        {
            return num1 + num2; 
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        //return types
        public string Text()
        {
            return "text";
        }

        //why to make it static?

        public Audi AudiCar(Audi audi)
        {
            return new Audi
            {
                Model = audi.Model,
                Color = "Audi q8",
                Price = audi.Price
            };
        }

        public object ObjectExercise()
        {
            return new object();    
        }

        public double DoubleTest()
        {
            return 123.45d + 456.32211d;
        }

        public string CarName()
        {
            var car = new BMW();
            return car.Name;
        }

        public Car CarType() // ??
        {
            var audi = new Audi();
            return audi;
        }

        public void Check()
        {
            string testCaseState = "Failed";
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
