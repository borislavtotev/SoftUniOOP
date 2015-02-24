using System;
using System.Collections.Generic;
using TheSlum.Interfaces;
using TheSlum.GameEngine;

namespace TheSlum
{
    class Mage : Character, IAttack
    {
        public Mage(string id, int x, int y, Team team, int healthPoints = 150, int defensePoints = 50, int attackPoints = 300, int range = 5)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = null;

            foreach (var character in targetsList)
	        {
		        if (character.IsAlive && character.Team != this.Team)
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
            this.AttackPoints += item.AttackEffect;
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

            this.AttackPoints -= item.AttackEffect;
            this.DefensePoints -= item.DefenseEffect;
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
    }
}
