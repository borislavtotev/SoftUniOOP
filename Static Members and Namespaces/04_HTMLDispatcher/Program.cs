using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HTMLDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 5);

            Console.WriteLine();
            Console.WriteLine(HTMLDispatcher.CreateImage("smiley.gif", "Smiley face", "Smiley title"));

            Console.WriteLine();
            Console.WriteLine(HTMLDispatcher.CreateURL("https://softuni.bg", "SoftUni", "Software University"));

            Console.WriteLine();
            Console.WriteLine(HTMLDispatcher.CreateInput("submit", "submitButton", "OK")); 
        }
    }
}