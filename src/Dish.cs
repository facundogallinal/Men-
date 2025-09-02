using System.Runtime.InteropServices.JavaScript;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; private set; }
        public double Price  { get; private set; }
        public bool IsVegetarian  { get; private set; }

        public Dish(string name, double price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }
        
    }
}