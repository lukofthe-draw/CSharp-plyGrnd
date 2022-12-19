using System.Collections.Generic;

namespace FridgeApp
{
    public class FoodGroup
    {
        public string Name { get; set; }
        public List<string> Foods { get; set; }

        public FoodGroup(string name)
        {
            Name = name;
            Foods = new List<string>();
        }
    }

    public class Meat : FoodGroup
    {
        public Meat() : base("Meat")
        {
            Foods.AddRange(new string[] { "Beef", "Pork", "Lamb", "Chicken", "Turkey" });
        }
    }

    public class Dairy : FoodGroup
    {
        public Dairy() : base("Dairy")
        {
            Foods.AddRange(new string[] { "Milk", "Cheese", "Yogurt", "Butter", "Ice Cream" });
        }
    }

    public class Grains : FoodGroup
    {
        public Grains() : base("Grains")
        {
            Foods.AddRange(new string[] { "Bread", "Pasta", "Rice", "Cereal", "Quinoa" });
        }
    }

    public class Fruits : FoodGroup
    {
        public Fruits() : base("Fruits")
        {
            Foods.AddRange(new string[] { "Apple", "Orange", "Banana", "Strawberry", "Grape" });
        }
    }

    public class Vegetables : FoodGroup
    {
        public Vegetables() : base("Vegetables")
        {
            Foods.AddRange(new string[] { "Carrot", "Tomato", "Lettuce", "Pepper", "Onion" });
        }
    }
}
