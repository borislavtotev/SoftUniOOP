using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.GameEngine
{
    class FullEngine : Engine
    {
        public override void Run()
        {
            base.Run();
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {                    
            switch (inputParams[1])
            {
                case "mage":
                    this.characterList.Add(new Mage(inputParams[2], Int32.Parse(inputParams[3]), Int32.Parse(inputParams[4]), this.GetInputTeam(inputParams[5])));
                    break;
                case "warrior":
                    this.characterList.Add(new Warrior(inputParams[2], Int32.Parse(inputParams[3]), Int32.Parse(inputParams[4]), this.GetInputTeam(inputParams[5])));
                    break;
                case "healer":
                    this.characterList.Add(new Healer(inputParams[2], Int32.Parse(inputParams[3]), Int32.Parse(inputParams[4]), this.GetInputTeam(inputParams[5])));
                    break;
                default:
                    break;
            }            
        }

        protected new void AddItem(string[] inputParams)
        {
            Character currentCharacter = GetCharacterById(inputParams[1]);
            
            switch (inputParams[2])
            {
                case "axe":
                    currentCharacter.AddToInventory(new Axe(inputParams[1]));
                    break;
                case "shield":
                    currentCharacter.AddToInventory(new Shield(inputParams[1]));
                    break;
                case "pill":
                    currentCharacter.AddToInventory(new Pill(inputParams[1]));
                    break;
                case "injection":
                    currentCharacter.AddToInventory(new Injection(inputParams[1]));
                    break;
                default:
                    break;
            }              
        }

        private Team GetInputTeam(string teamString)
        {
            Team currentTeam = Team.Blue;
            if (teamString == "Red")
            {
                currentTeam = Team.Red;
            }

            return currentTeam;
        }
    }
}
