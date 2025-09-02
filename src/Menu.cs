using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

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

        public void ReturnDish(Dish quitar)
        {
            dishes.Remove(quitar);
        }

        public Dish GetDishByName(Dish obtener)
        {
            if (dishes.Contains(obtener))
            {
                return (obtener);
            } 
            return null;
        }
    }   
}