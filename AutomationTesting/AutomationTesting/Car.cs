namespace AutomationTesting
{
    public abstract class Car
    {
        public string Name { get; set; }
        public int Price { get; set; } = 4;
        public string Model { get; set; } 

        public void CheckPrice()
        {
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
            return (Price == 0) ?  "No price" : "Price exists";
        }
    }
}
