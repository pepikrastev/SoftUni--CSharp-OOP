﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public int ToppingCounts => this.toppings.Count();

        public void AddTopping(Topping topping)
        {
            if (this.ToppingCounts == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

        public double GetTotalcalories()
        {
            return dough.CalculateCalories() + this.toppings.Select(x => x.CalculateCalories()).Sum();
        }
    }
}
