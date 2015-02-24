using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class Project: IProject
    {
        private string state;
        private string name;

        public Project(string name, DateTime startDate, string state, string details = null)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the project can't be empty.");
                }

                this.name = value;
            }
        }

        public DateTime StartDate { get; set; }

        public string Details { get; set; }

        public string State 
        {
            get { return this.state; }
            set 
            {
                if (value.ToLower() != "open" && value.ToLower() != "closed")
                {
                    throw new ArgumentOutOfRangeException("The state can be only open or closed.");
                }

                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = "closed";
        }

        public override string ToString()
        {
            if (this.Details == null)
            {
                return string.Format("ProjectName:{0} StartDate:{1} State:{2}", this.name, this.StartDate, this.state);
            }
            else
            {
                return string.Format("ProjectName:{0} StartDate:{1} State:{2} Details:{3}", this.name, this.StartDate, this.state, this.Details);
            }
        }
    }
}
