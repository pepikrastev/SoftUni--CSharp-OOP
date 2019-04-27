﻿using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        protected List<IAnimal> procedureHistory;

        public Procedure()
        {
            this.procedureHistory = new List<IAnimal>();
        }

        public string History()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");

            foreach (var animal in this.procedureHistory)
            {
                //sb.AppendLine($"    Animal type: {animal.GetType().Name} - {animal.Name} - Happiness: {animal.Happiness} - Energy: {animal.Energy}");
                sb.AppendLine(animal.ToString());
            }

            string result = sb.ToString().TrimEnd();

            return result;
        }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            if (procedureTime > animal.ProcedureTime)
            {
                throw  new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.ProcedureTime -= procedureTime;

            procedureHistory.Add(animal);
        }

    }
}
