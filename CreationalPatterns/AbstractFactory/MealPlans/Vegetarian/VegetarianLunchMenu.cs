﻿using System;
using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory.MealPlans.Vegetarian {
    public class VegetarianLunchMenu : IMenu {
        public List<string> MakeShoppingList()
            => new() { "black beans, spices, kale, cucumber" };

        public void PrintDescription() 
            => Console.WriteLine("The Vegetarian menu features plant-based options without meat products");

        public void PrintMenu() 
            => Console.WriteLine("Black Bean Soup, Green Curry, Salad");
    }
}
