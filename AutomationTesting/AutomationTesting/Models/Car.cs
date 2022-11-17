namespace AutomationTesting.Models
{
    public abstract class Car
    {
        public string Name { get; set; }
        public int Price { get; set; } = 4;
        public string Model { get; set; }

        public void CheckPrice()
        {
            //TODO refactoring
            if (Price == 0)
            {
                Console.WriteLine("No price");
            }
            else
            {
                Console.WriteLine("This is the price" + Price);
            }
        }

        public string CheckPrice2()
        {
            //TODO refactoring
            return Price == 0 ? "No price" : "Price exists";
        }

        // method override
        public virtual void Check() { }

    }
}
