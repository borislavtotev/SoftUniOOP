using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Batery batery;
    private double price;

    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen, string batery, double baterylife, double price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.LaptopBatery = new Batery(batery, baterylife);
        this.Price = price;
    }
    
    public string Model 
    { 
        get
        {
            return this.model;
        } 
        set 
        {
            if (String.IsNullOrEmpty(value))
	        {
		        throw new ArgumentException("Invalid Model");
	        }
            this.model = value;
        }
    }
    public string Manufacturer
    { 
        get
        {
            return this.manufacturer;
        } 
        set 
        {
            if (String.IsNullOrEmpty(value))
	        {
		        throw new ArgumentException("Invalid Manufacturer");
	        }
            this.manufacturer = value;
        }
    }
    public string Processor
    { 
        get
        {
            return this.processor;
        } 
        set 
        {
            if (String.IsNullOrEmpty(value))
	        {
		        throw new ArgumentException("Invalid Processor");
	        }
            this.processor = value;
        }
    }
    public int Ram
    { 
        get
        {
            return this.ram;
        } 
        set 
        {
            if (value<=0)
	        {
		        throw new ArgumentException("Invalid RAM. It should be a positive number");
	        }
            this.ram = value;
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid Graphics Card");
            }
            this.graphicsCard = value;
        }
    }
    public string HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid HDD");
            }
            this.hdd = value;
        }
    }
    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid Screen");
            }
            this.screen = value;
        }
    }
    private Batery LaptopBatery
    {
        get
        {
            return this.batery;
        }
        set
        {
            this.batery = value;
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
            if (value <= 0)
            {
                throw new ArgumentException("Invalid Price");
            }
            this.price = value;
        }
    }
    public override string ToString()
    {
        string output = "model: ".PadRight(20, ' ') + this.model + "\n";

        if (!String.IsNullOrEmpty(this.manufacturer))
        {
            output += "manufacturer: ".PadRight(20, ' ') + this.manufacturer + "\n";    
        }

        if (!String.IsNullOrEmpty(this.processor))
        {
            output += "processor: ".PadRight(20, ' ') + this.processor + "\n";
        }

        if (this.ram != 0)
        {
            output += "RAM: ".PadRight(20, ' ') + this.ram + " GB\n";
        }

        if (!String.IsNullOrEmpty(this.graphicsCard))
        {
            output += "graphics Card: ".PadRight(20, ' ') + this.graphicsCard + "\n";
        }

        if (!String.IsNullOrEmpty(this.hdd))
        {
            output += "HDD: ".PadRight(20, ' ') + this.hdd + "\n";
        }

        if (!String.IsNullOrEmpty(this.screen))
        {
            output += "screen: ".PadRight(20, ' ') + this.screen + "\n";
        }

        if (this.batery != null)
        {
            output += this.batery.ToString();    
        }
        
        output += "price: ".PadRight(20, ' ') + this.price + " lv.\n";
        return output;
    }
}


public class Batery
{
    private string model;
    private double life;
    
    public Batery() 
    {
    }

    public Batery(string model, double life)
    {
        this.Model = model;
        this.Life = life;
    }
    public string Model 
    { 
        get
        {
            return this.model;
        }
        set
        {
            if (String.IsNullOrEmpty(value)) 
            {
                throw new ArgumentNullException("Empty batery model.");
            }
            this.model = value;
        }
    }
    public double Life
    { 
        get
        {
            return this.life;
        }
        set
        {
            if (value<=0) 
            {
                throw new ArgumentOutOfRangeException("The Life of the batery must be greater than zero.");
            }
            this.life = value;
        }
    }
    public override string ToString()
    {
        string output;
        output = "batery: ".PadRight(20, ' ') + this.model + "\n";
        output += "batery life: ".PadRight(20, ' ') + this.life + " hours\n";
        return output;
    }
}

public class LaptopShop
{
    static void Main(string[] args)
    {
        Laptop newLaptop2 = new Laptop("Lenovo Yoga 2 Pro", 2259.00);
        Console.WriteLine(newLaptop2.ToString() + "\n");

        Laptop newLaptop1 = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "test model", 9.4, 2259.00);
        Console.WriteLine(newLaptop1.ToString() + "\n");
    }
}

