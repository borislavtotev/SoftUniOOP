using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HTMLDispatcher
{
    class ElementBuilder
    {
        public string tagName;
        public List<String> attributes = new List<string>();
        public List<String> values = new List<string>();
        public string content;

        public ElementBuilder(string elementName)
        {
            this.tagName = elementName;
        }

        public void AddAttribute(string atribute, string value)
        {
            this.attributes.Add(atribute);
            this.values.Add(value);
        }

        public void AddContent(string content)
        {
            this.content += content;
        }

        public override string ToString()
        {
            string output = "";

            output += "<" + this.tagName;

            for (int i = 0; i < this.attributes.Count; i++)
            {
                output += " " + this.attributes[i] + "=\"" + this.values[i] + "\"";
            }

            if (tagName == "input" || tagName == "img")
            {
                output += ">" + this.content;
            } 
            else
            {
                output += ">" + this.content + "</" + this.tagName + ">";
            }

            return output;
        }

        public static string operator *(ElementBuilder el1, int n)
        {
            string tagString = el1.ToString();
            for (int i = 0; i < n-1; i++)
			{
			     tagString+=tagString;
			}

            return tagString;
        }
    }
}
