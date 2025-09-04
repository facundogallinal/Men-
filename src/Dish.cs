using System.Runtime.InteropServices.JavaScript;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    
    
    /// creo la clase Dish
    public class Dish
    {
        /// Contendrá name, price y isVegetarian
        // Puede ser consultado por cualquier otro objeto pero los valores solo se los puede dar dentro de la clase
        public string Name { get; private set; }
        public double Price  { get; private set; }
        public bool IsVegetarian  { get; private set; }

        // Este es el creador que recibe los parametros y crea el nuevo objeto
        public Dish(string name, double price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }
        
    }
}