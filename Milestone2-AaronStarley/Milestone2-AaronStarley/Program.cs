/*
Aaron Starley
12-14-2022
CST-150-O500

This program contains my "Item" class.
A "aluminum can" "Item" is created below. Different getters and setters
are manipulated.
Then a "default" "Item" is created, but with no information provided for
the constructor, so the default constructor is used.

There isn't any error handling, but we aren't processing (much) data
yet, but I'm not worried yet since this is just creating the class
based on the UML and testing it. Once a user can interact with it I will
worry more.
 */

// See https://aka.ms/new-console-template for more information
/*I don't like that Visual Studio does this ^
 * I'll have to find how to turn that "feature" off next time. */ 



using System.Reflection.Metadata.Ecma335;
namespace Milestone2AaronStarley{
public static class Program { 
    public static void Main() { 
    //Creating a Item object
        Item AluminumCan = new Item("Aluminum Can", 12345678, 100000000001, 12, 2.05F);
        Item Default = new Item();
        
        Console.WriteLine("Item");
        Console.WriteLine(AluminumCan.name);
        Console.WriteLine("$"+AluminumCan.price);
        Console.WriteLine(AluminumCan.stock+" in stock");
        AluminumCan.discountPercent=0.15F;
        Console.WriteLine("$"+AluminumCan.discountPrice.ToString("0.00"));
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Item");
        Console.WriteLine(Default.name);
        Console.WriteLine("$"+Default.price);
        Console.WriteLine(Default.stock+" in stock");
        }
    }
    class Item { 
        private string Name;
        private int SKU;
        private long UPC;
        int Stock;
        float Price;
        float DiscountPercent = 0;
        public Item(string name, int sku, long upc, int stock, float price) { 
            Name = name;
            SKU = sku;
            UPC = upc;
            Stock = stock;
            Price = price;
        }    
        public Item() { 
            Name = "Turbo Encabulator";
            SKU = 12311962;
            UPC = 0000000000000000;
            Stock = 0;
            Price = 750000000.00F;
        }
        public string name {
            get { return Name;}
        }
        public int sku { 
            get { return SKU;}
        }
        public long upc {
            get { return UPC;}    
        }
        public int stock {
            get { return Stock;}
            set { Stock = value;}
        }
        public float price { 
            get { return Price;}
            set { Price = value;}
        }
        public float discountPercent {
            get { return DiscountPercent;}
            set { DiscountPercent = value;}
        }
        public float discountPrice {
            get { return price*(1-discountPercent);}//I think I'm doing my math right...
        }
    }  
}