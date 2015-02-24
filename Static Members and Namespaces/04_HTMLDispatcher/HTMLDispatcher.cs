using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HTMLDispatcher
{
    class HTMLDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder newImage = new ElementBuilder("img");
            newImage.AddAttribute("src", imageSource);
            newImage.AddAttribute("alt", alt);
            newImage.AddAttribute("title", title);

            return newImage.ToString();
        }
        
        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder newURL = new ElementBuilder("a");
            newURL.AddAttribute("href", url);
            newURL.AddAttribute("title", title);
            newURL.AddContent(text);

            return newURL.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder newInput = new ElementBuilder("input");
            newInput.AddAttribute("type", inputType);
            newInput.AddAttribute("name", name);
            newInput.AddAttribute("value", value);

            return newInput.ToString();
        }

    }
}
