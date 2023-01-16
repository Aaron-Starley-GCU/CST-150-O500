using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Milestone4_AaronStarley {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int sku;
            float newPrice;
            Form1.Item searchResult;
            
            sku = Convert.ToInt32(updateSkuBox.Text);
            newPrice = float.Parse(newPriceBox.Text);

            searchResult = Form1.IM.searchSKU(sku);
            searchResult.price = newPrice;
            Form1.updateInvTextBox();
            Close();
            
        }
    }
}
