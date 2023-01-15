/*
Aaron starley
1-14-23
CST150-O500
 */

namespace Activity15_AaronStarley {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            dayBox.Enabled = false;
            graduationBox.Enabled = false;
            button1.Enabled = false;
            for (int i = 2022; i >= 1900; i--) { //populating graduation years
                graduationBox.Items.Add(i);    
            }  
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e) {
            int mon = monthBox.SelectedIndex;
            mon+=1;

            //Resetting, then populating possible days based on month.
            dayBox.Items.Clear();
            if (mon == 2 || mon == 4 || mon == 6 || mon == 9 || mon == 11) {
                for (int i = 1; i <= 30; i++) {
                    dayBox.Items.Add(i);
                }
            } else { 
                for (int i = 1; i <= 31; i++) {
                    dayBox.Items.Add(i);
                }
            }
            dayBox.Enabled = true;
        }
        private void dayBox_SelectedIndexChanged(object sender, EventArgs e) {
            graduationBox.Enabled = true;
        }
        private void graduationBox_SelectedIndexChanged(object sender, EventArgs e) {
            button1.Enabled=true;
            button1.Text= "What's my Lucky Number?";
        }

        private void button1_Click(object sender, EventArgs e) {//"Calculating" lucky number
            int luckyNumber;
            int x = Convert.ToInt32(graduationBox.SelectedItem)%100;
            luckyNumber = (dayBox.SelectedIndex * monthBox.SelectedIndex)+2 * (x+1);
            luckyNumber = luckyNumber%100;
            

            //Creating instance of Form2, and sending it our lucky number.
            Form2 outputForm = new Form2(luckyNumber);
            outputForm.Show();
        }

        
    }
}