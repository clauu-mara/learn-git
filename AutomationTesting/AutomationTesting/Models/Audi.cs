namespace AutomationTesting.Models
{
    public class Audi : Car
    {
        public string? Color { get; set; }


        public static void Warning()
        {
            Console.WriteLine("Error message");
        }

        public override void Check()
        {
            var testCaseState = "Inconclusive"; // i can delete the brackets
            switch (testCaseState)
            {
                case "Passed":
                    Console.WriteLine("The case Passed");
                    break;
                case "Failed":
                    Console.WriteLine("The case Failed");
                    break;
                case "Inconclusive":
                    Console.WriteLine("The case inconclusive");
                    break;
            }
        }

        public static void ForStatement()
        {
            //assigning
            //conditional checking
            //incrementing
            for (var i = 0; i < 10; i++)
                Console.WriteLine("The number of time is: " + i);

        }
    }
}
