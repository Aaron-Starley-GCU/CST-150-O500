/*
Aaron Starley
1-15-2023
CST 150-O500

Milestone 5

Loom video link:https://loom.com/share/55c67749e953448e8c7da60843341cd9


CREDIT https://stackoverflow.com/questions/44197714/update-richtextbox-using-static-methods
I would not have figured out references on my own, so credit where credit is due.
But, this was necessary for letting other forms update the richTextBox that displays
the inventory items.

 
 */

using System.DirectoryServices;

namespace Milestone4_AaronStarley {
    public partial class Form1 : Form {
        public static InventoryManager IM = new InventoryManager();
        private static Form1 frmReference; //CREDIT https://stackoverflow.com/questions/44197714/update-richtextbox-using-static-methods
        
        public Form1() {
            frmReference = this;
            InitializeComponent();
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
            updateInvTextBox();
        }
        public static void updateInvTextBox() {
            frmReference.richTextBox1.Text=IM.displayItems();
            // CREDIT https://stackoverflow.com/questions/44197714/update-richtextbox-using-static-methods
        }
       


        private void addItemButton_Click(object sender, EventArgs e) {
           Form2 addItemForm = new Form2();
            addItemForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e) {
            Item searchResult;
            bool found = false;
            try {
                int sku = Convert.ToInt32(skuSearchBox.Text);
                searchResult = IM.searchSKU(sku);
                found = true;
            } catch {
                searchResult = IM.searchSKU(0); 
            }
            if (!found) {
                try {
                    int stock = Convert.ToInt32(stockSearchBox.Text);
                    searchResult = IM.searchStock(stock);
                    found = true;
                } catch {
                    searchResult = IM.searchSKU(0);
                }
            }
            if (found) {
                try {
                    string searchText = "";
                    searchText += searchResult.name + ", ";
                    searchText += "SKU:" + searchResult.sku + ", ";
                    searchText += "UPC:" + searchResult.upc + ", ";
                    searchText += "Stock:" + searchResult.stock + ", ";
                    searchText += "Price: $" + searchResult.price + "\n";
                    searchResultBox.Text = searchText;
                } catch {
                    searchResultBox.Text = "ERROR";
                }
            } else {
                searchResultBox.Text = "No item found";
            }
            skuSearchBox.Clear();
            stockSearchBox.Clear();
        }

        private void updateStockButton_Click(object sender, EventArgs e) {
           
           Form3 updateItemForm = new Form3();
           updateItemForm.Show();
        }

        private void updatePriceButton_Click(object sender, EventArgs e) {
            Form4 updatePriceForm = new Form4();
            updatePriceForm.Show();
        }



    public class Item {
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



    public class InventoryManager{
     
        List<Item> itemList = new List<Item>();
        public void addItem(Item i) {
            itemList.Add(i);
        }
        public void removeItem(int sku) {
            itemList.Remove(itemList.Find(Item => Item.sku == sku));
        }

        public void restock(int sku, int quantity) {
            Item searchResult = searchSKU(sku);
            searchResult.stock+=quantity;
        }


        public string displayItems() {
            string outputText = "";
            foreach (Item i in itemList) { 
                outputText += i.name + ", ";
                outputText += "SKU:"+i.sku + ", ";
                outputText += "UPC:"+i.upc + ", ";
                outputText += "Stock:"+i.stock + ", ";
                outputText += "Price: $"+i.price + "\n";
            }
            return outputText; 
        }

        public Item searchStock(int quantity) { 
            int x = quantity;
            Item searchedItem = itemList.Find(Item => Item.stock == quantity);
            return searchedItem;
        }    
        public Item searchSKU(int skew) { 
            int sku = skew;
            Item searchedItem = itemList.Find(Item => Item.sku == sku);
            return searchedItem;
        }  
        
    }

        private void Form1_Load(object sender, EventArgs e) {

        }

        
    }
}