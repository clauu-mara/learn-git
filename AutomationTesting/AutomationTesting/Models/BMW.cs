namespace AutomationTesting.Models
{
    public class BMW : Car
    {
        public string Color { get; set; }


        public void Warning()
        {
            Console.WriteLine("Alert");
        }

        public override void Check()
        {
            //TODO ternary operator
            var testCaseState = true;
            if (testCaseState)
                Console.WriteLine("The case PASSED");
            else
                Console.WriteLine("The case FAILED");
        }

        public void WhileStatement()
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
