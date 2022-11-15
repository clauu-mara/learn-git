namespace AutomationTesting
{
    class Class2
    {
        private int myVariable;

        //TODO refactoring
        public void SetValue(int value)
        {
            myVariable = value; 
        }

        public void GetValue()
        {
            //TODO refactoring
            if (myVariable > 0)
            {
                Console.WriteLine("Variable {0} > 0 ", myVariable);
            }
            else if (myVariable < 0)
            {
                Console.WriteLine("Variable {0} < 0 ", myVariable);
            }
            else
            {
                Console.WriteLine("Variable = 0");
            }
        }
    }
}
