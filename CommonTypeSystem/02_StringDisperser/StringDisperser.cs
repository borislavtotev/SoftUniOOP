using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringDisperser
{
    class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<StringDisperser>
    {
        private List<Char> chars = new List<char>();

        public StringDisperser(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                char[] newChars = strings[i].ToCharArray();
                for (int j = 0; j < newChars.Length; j++)
                {
                    this.chars.Add(newChars[j]);
                }
            }
        }

        public void Add(string newString)
        {
            for (int i = 0; i < newString.Length; i++)
            {
                this.chars.Add(newString[i]);
            }
        }

        public override string ToString()
        {
            return string.Join("", this.chars.ToArray());
        }

        public override bool Equals(object obj)
        {
            StringDisperser other = (StringDisperser)obj;
            if (this.chars.Count != other.chars.Count)
            {
                return false;
            } 

            return other.ToString() == this.ToString();
        }

        public static bool operator == (StringDisperser stringDisperser1, StringDisperser stringDisperser2) 
        {
            return stringDisperser1.Equals(stringDisperser2);
        }

        public static bool operator != (StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return !(stringDisperser1.Equals(stringDisperser2));
        }

        public override int GetHashCode()
        {
            return this.chars.GetHashCode();
        }

        public object Clone()
        {
            string currentString = this.ToString();
            return new StringDisperser(currentString);
        }

        public int CompareTo(StringDisperser other)
        {
            return this.ToString().CompareTo(other.ToString());
        }

        public IEnumerator<StringDisperser> GetEnumerator()
        {
            for (int i = 0; i < this.chars.Count; i++)
            {
                yield return new StringDisperser(this.chars[i].ToString());
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
