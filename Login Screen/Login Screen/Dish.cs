using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main
{
     public class dish
    {
        public string DishName;
        public float DishPrice;
        public int DishSize;
        public string DishDescripation;
        public string image;

       public dish()
        {
           
        }
        public string getDishName()
        {
            return DishName;
        }
        public float getPrice(String DishName, int DishSize)
        {
            return DishPrice;
        }
        public int getDishSize(String DishName)
        {
            return DishSize;  
        }
        public string getDishDescripation(String name)
        {
            return DishDescripation;
        }
    }
}
