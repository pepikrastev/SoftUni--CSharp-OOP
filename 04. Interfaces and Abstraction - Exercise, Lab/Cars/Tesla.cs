﻿namespace Cars
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   

    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = battery;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Batteries { get; private set; }

      

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Batteries} Batteries")
                .AppendLine(this.Start())
                .AppendLine(this.Stop());

            return sb.ToString().Trim();
        }
    }
}