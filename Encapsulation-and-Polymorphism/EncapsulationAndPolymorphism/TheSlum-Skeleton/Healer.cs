using System;
using System.Collections.Generic;
using TheSlum.Interfaces;
using TheSlum.GameEngine;

namespace TheSlum
{
    class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team, int healthPoints = 75, int defensePoints = 50, int healingPoints = 60, int range = 6)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            int minHealthPoints = Int32.MaxValue;
            Character target = null;

            foreach (var character in targetsList)
	        {
                if (character.IsAlive && character.Team == this.Team && character.HealthPoints < minHealthPoints && character != this)
	            {
                    target = character;
	            }
	        }

            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.HealthPoints -= item.HealthEffect;
            if (this.HealthPoints < 1)
            {
                this.HealthPoints = 1;
            }

            this.DefensePoints -= item.DefenseEffect;
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}
