﻿namespace AutomationTesting
{
    public class Audi : Car 
    {
        public string Name { get; set; }    
        public void Warning()
        {
            Console.WriteLine("Error message");
        }
        public void Check()
        {
            string testCaseState = "Inconclusive"; // i can delete the brackets
            if(testCaseState == "Passed")
                Console.WriteLine("The case Passed");
            else if(testCaseState == "Failed")
                Console.WriteLine("The case Failed");
            else if( testCaseState == "Inconclusive")
                Console.WriteLine("The case inconclusive");
        }  

        public void ForStatement()
        {
            //assigning
            //conditional checking
            //incrementing
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("The number of time is: " + i );
            }
        }
    }
}
