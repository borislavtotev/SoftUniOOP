using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal: ISound
    {
        private string name;
        private uint age;
        private string gender;

        public Animal(string name, uint age)
            : this(name, age, null)
        {
        }

        public Animal(string name, uint age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        { 
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the animal can't be empty.");
                }
                this.name = value;
            }
        }

        public uint Age
        {
            get { return this.age; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("The age can't be 0.");
                }

                this.age = value;
            }
        }

        public string Gender 
        { 
            get { return this.gender; }
            set
            {
                if (value == null)
                {
                    this.gender = "";
                }
                else
                {
                    if (value.ToLower() != "male" && value.ToLower() != "female")
                    {
                        throw new ArgumentException("The gender can be only male or female");
                    }

                    this.gender = value;
                }
            }
        }

        public virtual void ProduceSound()
        {
        }

        public override string ToString()
        {
            if (this.gender!="")
            {
                return string.Format("Name:{0}\tAge:{1}\tGender:{2}",this.name, this.age, this.gender); 
            }
            else
            {
                return string.Format("Name:{0}\tAge:{1}", this.name, this.age);
            }
            
        }
        
    }
}
