namespace Iterator.Restaurants.Models
{
    public class MenuItem
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public bool Vegetarian { get; protected set; }
        public double Price { get; protected set; }

        public MenuItem(string name, string description, bool vegetarian,  double price)
        {
            Name = name;
            Price = price;
            Vegetarian = vegetarian;
            Description = description;
        }
    }
}
