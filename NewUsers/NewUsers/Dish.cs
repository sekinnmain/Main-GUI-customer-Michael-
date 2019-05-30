using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main
{
    class dish
    {
        public string DishName;
        public float DishPrice;
        public int DishSize;
        public string DishDescripation;
        public string image;

       public dish(string dishname,float dishprice,int dishSize,string dishDescripation, string image)
        {
           DishName = dishname;
            DishPrice = dishprice;
            DishSize = dishSize;
            DishDescripation = dishDescripation;
            this.image = image;
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
