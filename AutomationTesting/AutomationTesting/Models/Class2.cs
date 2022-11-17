namespace AutomationTesting.Models
{
    class Class2
    {
        private int _myVariable;

        //TODO refactoring
        public void SetValue(int value)
        {
            _myVariable = value;
        }

        public void GetValue()
        {
            //TODO refactoring
            if (_myVariable > 0)
            {
                Console.WriteLine("Variable {0} > 0 ", _myVariable);
            }
            else if (_myVariable < 0)
            {
                Console.WriteLine("Variable {0} < 0 ", _myVariable);
            }
            else
            {
                Console.WriteLine("Variable = 0");
            }
        }
    }
}
