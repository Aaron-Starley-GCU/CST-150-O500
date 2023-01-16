using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4_AaronStarley {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e) {
           string newName = nameInputBox.Text;
           int newSku = Convert.ToInt32(skuInputBox.Text);
           long newUPC = Convert.ToInt64(upcInputBox.Text);
           int newStock = Convert.ToInt32(stockInputBox.Text);
           float newPrice = float.Parse(priceInputBox.Text);
           Form1.Item inputItem = new Form1.Item(newName, newSku, newUPC, newStock, newPrice);
           Form1.IM.addItem(inputItem);
           nameInputBox.Clear();
           skuInputBox.Clear();
           upcInputBox.Clear();
           stockInputBox.Clear();
           priceInputBox.Clear();
           Close();
        }
    }
}
