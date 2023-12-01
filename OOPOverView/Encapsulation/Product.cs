namespace Encapsulation
{
    internal class Product
    {
        private double price;

        public void SetPrice(double value)
        {
            if (value < 0)
            {
                throw new Exception("0'dan küçük olmasın");
            }

            this.price = value;
        }

        public double GetPrice()
        {
            return price;
        }

        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        //Her ürünün ................. vardır
        public string Description { get; set; }

        public Category Category { get; set; }

        public int Stock { get; private set; }

        public void UpdateStock(int value)
        {
            //IsCreated = true;
            Stock = value;
        }

        public bool IsCreated { get; }

        public Product()
        {
            IsCreated = true;
        }

    }
}
