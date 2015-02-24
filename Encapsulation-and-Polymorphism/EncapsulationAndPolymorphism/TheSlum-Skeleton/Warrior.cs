using System;
using System.Collections.Generic;
using TheSlum.Interfaces;
using TheSlum.GameEngine;

namespace TheSlum
{
    class Warrior : Character, IAttack
    {
        public Warrior(string id, int x, int y, Team team, int healthPoints = 200, int defensePoints = 100, int attackPoints = 150, int range = 2):base(id,x,y,healthPoints,defensePoints,team,range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            foreach (var character in targetsList)
	        {
		        if (character.IsAlive && character.Team != this.Team)
	            {
		            return character;
	            }
	        }

            return null;
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
