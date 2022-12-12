namespace AutomationTesting.Models
{
    public class BMW : Car
    {
        public string? Color { get; set; }


        public static void Warning()
        {
            Console.WriteLine("Alert");
        }

        public static string UseTernaryOperator(bool state)
        {
            return state ? "The case Passed" : "The case Failed";
        }

        public static void WhileStatement()
        {
            var elementNotVisible = true;
            var mockNoOfSeconds = 0;
            while (elementNotVisible)
            {
                Console.WriteLine("No of seconds waiting:" + mockNoOfSeconds);
                if (mockNoOfSeconds == 5)
                    elementNotVisible = false;
                mockNoOfSeconds++;
            }
        }
    }
}
