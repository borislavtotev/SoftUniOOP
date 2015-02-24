using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class People: DetailsClass
    {
        private string name;

        public People(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
        }
        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("The name cann't be empty");
                }
                this.name = value;
            } 
        }
    }
}
