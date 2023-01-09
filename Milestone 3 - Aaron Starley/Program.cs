/*
Aaron Starley
1-8-2022
CST-150-O500

This program contains my "Item" and "InventoryManager" classes.


There isn't any error handling, but we aren't processing (much) data
yet, but I'm not worried yet since this is just creating the class
based on the UML and testing it. Once a user can interact with it I will
worry more.

The required use of an Array, instead of a List, makes managing items more difficult.
I have to assume a set number of different items at any given time. This cannot expand
or contract easily.
 */


using System.Reflection.Metadata.Ecma335;
namespace Milestone3AaronStarley {
    public static class Program {
        public static void Main() {
            
            //Creating Item objects
            Item AluminumCan = new Item("Aluminum Can", 1, 100000000001, 12, 2.05F);
            Item Default = new Item();
            Item FT818 = new Item("Yeasu FT-818", 2, 100000000001, 0, 649.99F);
            Item TangoII = new Item("TBS Tango II", 3, 100000000001, 1, 299.99F);
            Item Cards = new Item("Bicycle Playing Cards", 4, 100000000001, 2, 4.99F);
            Item DietDew = new Item("Diet Mtn Dew (12oz)-12Pack", 5, 100000000001, 4, 6.98F);
            Item TestorsBlack = new Item("Testors Enamel Paint (Gloss Black)", 6, 100000000001, 10, 2.09F);
            Item TestorsGrey = new Item("Testors Enamel Paint (Gloss Grey)", 7, 100000000001, 10, 2.09F);
            Item TestorsRed = new Item("Testors Enamel Paint (Gloss Red)", 8, 100000000001, 10, 2.09F);
            Item TestorsBlue = new Item("Testors Enamel Paint (Gloss Blue)", 9, 100000000001, 10, 2.09F);
            
            //Creating Inventory Manager object
            InventoryManager IM = new InventoryManager();
            
            IM.addItem(AluminumCan);
            IM.addItem(Default);
            IM.addItem(FT818);
            IM.addItem(TangoII);
            IM.addItem(Cards);
            IM.addItem(DietDew);
            IM.addItem(TestorsBlack);
            IM.addItem(TestorsGrey);  
            IM.addItem(TestorsRed);
            IM.addItem(TestorsBlue);
            
            //Removing and replacing item
            IM.removeItem(1);
            Item DietCoke = new Item("Diet Coke (12oz)-12Pack", 1 ,100000000001, 0, 6.98F);
            IM.addItem(DietCoke);
            IM.restock(1, 10); //(re)stocking said item

            IM.restock(2, 1);
            IM.removeItem(8);
            IM.displayItems();

            //Searching inventory by stock and price.
            Console.WriteLine("------------Searching inventory------------");
            IM.searchItems(10, 2.09f);
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
            SKU = 0;
            UPC = 0000000000000000;
            Stock = 0;
            Price = 750000000.00F;
        }
        public string name {
            get { return Name; }
        }
        public int sku {
            get { return SKU; }
        }
        public long upc {
            get { return UPC; }
        }
        public int stock {
            get { return Stock; }
            set { Stock = value; }
        }
        public float price {
            get { return Price; }
            set { Price = value; }
        }
        public float discountPercent {
            get { return DiscountPercent; }
            set { DiscountPercent = value; }
        }
        public float discountPrice {
            get { return price * (1 - discountPercent); }//I think I'm doing my math right...
        }
    }


    //Milestone 3 Starts here
    class InventoryManager{
        Item[] items = new Item[10];
        public void addItem(Item i) {
            int x = i.sku;
            items[x] = i;
        }
        public void removeItem(int sku) {
            Item VOID = new Item("-VOID-", sku, 100000000001, 0, 0.00F);
            items[sku]=VOID;
        }

        public void restock(int sku, int quantity) {
            int x = items[sku].stock;
            items[sku].stock+=quantity;
        }


        public void displayItems() {
            for (int i = 0; i < items.Length; i++) {   
                Console.WriteLine("---------");
                Console.WriteLine(items[i].name);
                Console.WriteLine("$" + items[i].price);
                Console.WriteLine(items[i].stock + " in stock");
            }   
        }

        public void searchItems(int quantity, float cost) { 
            int x = quantity;
            float c = cost;

            for (int i = 0; i < items.Length; i++) {
                if (items[i].stock == x && items[i].price == c) {
                Console.WriteLine("---------");
                Console.WriteLine(items[i].name);
                Console.WriteLine("$" + items[i].price);
                Console.WriteLine(items[i].stock + " in stock");
                }    
            }
        }
        
    }
}