using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorTest.Shared
{
    public class FoodStuff : ComponentBase
    {
        public string IngredientID { get; set; }
        public string IngredientName { get; set; }
        public int count { get; set; }

        protected IList<FoodStuff> ings = new List<FoodStuff>();
        protected string newTodo = "1";
        protected string newTodo1 = "Eggs";
        protected int counter = 8;
        
        protected void populateList()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                ings.Add(new FoodStuff { IngredientID = newTodo, IngredientName = newTodo1, count = counter });
                ings.Add(new FoodStuff { IngredientID = "2", IngredientName = "Chicken", count = 5 });
                ings.Add(new FoodStuff { IngredientID = "3", IngredientName = "Rice", count = 10 });
                newTodo = string.Empty;
                
            }
        }
    }
}
