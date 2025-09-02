using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish añadir)
        {
            dishes.Add(añadir);
        }
        public void RemoveDish(Dish quitar)
        {
            dishes.Remove(quitar);
        }
        public Dish GetDishByName(string obtener)
        {
            foreach (Dish item in this.dishes)
            {
                if (obtener == item.Name)
                {
                    return item;
                }
            }

            return null;
        }
    }
}