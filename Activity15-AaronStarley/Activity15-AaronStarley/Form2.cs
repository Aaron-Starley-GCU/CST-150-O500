using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15_AaronStarley {
    public partial class Form2 : Form {
        public Form2(int x) {
            InitializeComponent();
            numLabel.Text = x.ToString();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }
    }
}
