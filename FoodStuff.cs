using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorTest.Shared
{
    public class FoodStuff : ComponentBase
    {
        //ingredient stuff
        public string IngredientID { get; set; }
        public string IngredientName { get; set; }
        public int count { get; set; }
        //dishstuff
        public string DishID { get; set; }
        public string DishName { get; set; }
        public int Price { get; set; }
        public int Preptime { get; set; }

        protected IList<FoodStuff> ings = new List<FoodStuff>();
        protected IList<FoodStuff> dishes = new List<FoodStuff>();
        protected string newTodo = "1";
        protected string newTodo1 = "Eggs";
        protected int counter = 8;
        protected int restockquant = 0;

        protected string namecheck;
        protected int pricecheck;

        protected void PopulateList()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                ings.Add(new FoodStuff { IngredientID = newTodo, IngredientName = newTodo1, count = counter });
                ings.Add(new FoodStuff { IngredientID = "2", IngredientName = "Chicken", count = 5 });
                ings.Add(new FoodStuff { IngredientID = "3", IngredientName = "Rice", count = 10 });
                newTodo = string.Empty;
            }
        }

        protected void Restock()
        {
            //restock

        }

        protected void Dispose()
        {
            //restock
        }

        protected void PopulateDishes()
        {
                dishes.Add(new FoodStuff { DishID = "1", DishName = "Fried Fish", Price = 10, Preptime = 30 });
                dishes.Add(new FoodStuff { DishID = "2", DishName = "Nuggets", Price = 6, Preptime = 10 });
                dishes.Add(new FoodStuff { DishID = "3", DishName = "Spicy Boi", Price = 8, Preptime = 20 });
        }

        protected void expensiveIngredientDishes()
        {

        }

        protected void SearchDish()
        {

        }
    }
}
