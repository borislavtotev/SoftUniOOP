using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Computer
{
    private string name;
    private Component[] components;
    private double price;

    public Computer(string name, Component[] components)
    {
        this.Name = name;
        this.Components = components;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name of the computer can not be Empty");
            }
            this.name = value;
        }
    }
    public Component[] Components 
    { 
        get
        {
            return this.components;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentException("The components are empty");
            }
            this.components = value;

            double totalPrice = 0;

            foreach (var component in this.components)
            {
                totalPrice += component.Price;
            }
            this.price = totalPrice;
        }
    }
    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            double totalPrice = 0;

            foreach (var component in this.components)
            {
                totalPrice += component.Price;
            }
            this.price = totalPrice;
        }
    }
 
    public void Display()
    {
        string output = this.name + "\n";
        double totalPrice = 0;

        foreach (var component in this.components)
        {
            output += component.Name.PadRight(25, ' ')+component.Price+" BGN\n";
            totalPrice += component.Price;
        }
        output += "Total price: ".PadRight(25, ' ') + totalPrice + " BGN\n";
        Console.WriteLine(output);
    }
}


public class Component
{
    private string name;
    private string details;
    private double price;

    public Component(string name, double price, string details = null) 
    {
        this.Name = name;
        this.Details = details;
        this.Price = price; 
    }

    public string Name 
    {
        get
        {
            return this.name;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name of the component can not be Empty");    
            }
            this.name = value;
        }
    }
    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name of the component can not be Empty");
            }
            this.details = value;
        }
    }
    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentNullException("The name of the component can not be Empty");
            }
            this.price = value;
        }
    }
    public void GetProperties()
    {
        Console.WriteLine(this.name.PadRight(20, ' ') + this.price + " BGN\n"); 
    }

}

class PCCaralog
{
    static void Main(string[] args)
    {
        Component RAM1 = new Component("RAM", 123.23, "8 GB RAM");
        Component RAM2 = new Component("RAM", 163.76, "12 GB RAM");
        Component RAM3 = new Component("RAM", 196.42, "16 GB RAM");

        Component CPU1 = new Component("CPU", 135.23, "Intel Core i3");
        Component CPU2 = new Component("CPU", 234.25, "Intel Core i5");
        Component CPU3 = new Component("CPU", 234.25, "Intel Core i7");

        Component HDD1 = new Component("HDD", 75.23, "50GB SSD");
        Component HDD2 = new Component("HDD", 124.35, "100GB SSD");
        Component HDD3 = new Component("HDD", 144.26, "150GB SSD");

        Component GraphicsCard2 = new Component("Graphics Card", 45.35, "Intel HD Graphics 4400");
        Component GraphicsCard3 = new Component("Graphics Card", 104.26, "Intel HD Graphics 8400"); 

        Computer PC1 = new Computer("Pravetz 1", new Component[3] { RAM1, CPU1, HDD1});
        Computer PC2 = new Computer("Pravetz 2", new Component[4] { RAM2, CPU2, HDD2, GraphicsCard2 });
        Computer PC3 = new Computer("Pravetz 3", new Component[4] { RAM3, CPU3, HDD3, GraphicsCard3 });
        Computer PC4 = new Computer("Pravetz 4", new Component[4] { RAM1, CPU2, HDD3, GraphicsCard3 });

        var allComputers = new List<Computer>() {PC1,PC2,PC3,PC4};
        
        IEnumerable<Computer> query = allComputers.OrderBy(Computer => Computer.Price);

        foreach (Computer pc in query)
        {
            pc.Display();
        }
    
    }
}

