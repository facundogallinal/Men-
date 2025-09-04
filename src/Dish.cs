using System.Runtime.InteropServices.JavaScript;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    
    
    /// creo la clase Dish. Contiene Name, Price y IsVegetarian
    public class Dish
    {
        // se puede llamar desde cualquier objeto pero solo modificar desde la misma clase
        public string Name { get; private set; }
        public int Price  { get; private set; }
        public bool IsVegetarian  { get; private set; }

        // creo el constructor que recibe los parametros y le asigna los valores al nuevo dish
        public Dish(string name, int price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }
        
    }
}