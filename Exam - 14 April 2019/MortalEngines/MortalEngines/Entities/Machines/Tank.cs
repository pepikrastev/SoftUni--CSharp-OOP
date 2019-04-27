﻿using MortalEngines.Entities.Contracts;
using MortalEngines.Entities.Mashines;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities.Machines
{
    public class Tank : BaseMachine, ITank
    {
        private const int initialHealthPoints = 100;
        private int health = initialHealthPoints;
        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.DefenseMode = false;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {

            if (this.DefenseMode == false)
            {
                this.DefenseMode = true;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }

            else
            {
                this.DefenseMode = false;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            var deffenceMOdeStatus = this.DefenseMode == true ? "ON" : "OFF";
            return base.ToString() + $"{Environment.NewLine} *Defense: { deffenceMOdeStatus}";

        }
    }
}