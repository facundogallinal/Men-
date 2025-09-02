using System.Runtime.InteropServices.JavaScript;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string name { get; private set; }
        public int price  { get; private set; }
        public bool isVegetarian  { get; private set; }

        public Dish(string name, int price, bool isVegetarian)
        {
            this.name = name;
            this.price = price;
            this.isVegetarian = isVegetarian;
        }
        
    }
}