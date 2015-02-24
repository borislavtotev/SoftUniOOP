using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StudentClass
{
    public delegate void ChangedEventHandler(object sender, PropertyChangedEventArgs e);

    public class Student
    {
        public event ChangedEventHandler PropertyChanged;
        private string name;
        private uint age = 0;

        public Student(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        { 
            get {return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can't be empty.");
                }

                if (this.name != null)
                {
                    OnChanged(new PropertyChangedEventArgs("Name", this.name, value));
                }
                
                this.name = value;
            }
        }
        
        public uint Age 
        {
            get {return this.age; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("The age can't be 0");
                }
   
                if (this.age != 0)
	            {
		            OnChanged(new PropertyChangedEventArgs("Age", this.age.ToString(), value.ToString()));
	            }
                
                this.age = value;
            }
        }

        protected virtual void OnChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
