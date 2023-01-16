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
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void updateStockButton_Click(object sender, EventArgs e) {
            int sku;
            int change;
            //Form1.Item searchResult;
            try {
                sku = Convert.ToInt32(updateSkuBox.Text);
                change = Convert.ToInt32(numericUpDown1.Value);
                Form1.IM.restock(sku, change);
            } catch { 
                updateSkuBox.Text="Error!";
            }
            updateSkuBox.Clear();
            numericUpDown1.Value = 0;
            Form1.updateInvTextBox();
            Close();
        
        }

        private void removeButton_Click(object sender, EventArgs e) {
             int sku;
            try { 
                sku = Convert.ToInt32(updateSkuBox.Text);
                Form1.IM.removeItem(sku);
            } catch { 
                updateSkuBox.Text="Error!";
            }
            updateSkuBox.Clear();
            Form1.updateInvTextBox();
            Close();
        }

        private void guardCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (guardCheckBox.Checked) {
                removeButton.Enabled = true;
            } else { 
                removeButton.Enabled = false;    
            }
        }
    }
}
