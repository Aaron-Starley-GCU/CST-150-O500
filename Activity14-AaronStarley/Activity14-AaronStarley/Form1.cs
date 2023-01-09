/*
 Aaron Starley
 1-8-23
 CST 150-O500
 
 Where I was allowed to create anyting as long as I used RadioButtons, CheckBoxes,
and a List Box, I decided to expand on my work from Activities 2 and 6.

This program gives info on Ham Radio Bands and Band privileges for different license classes.
I got the information used from this chart http://www.arrl.org/images/view//Charts/Band_Chart_Image_for_ARRL_Web.jpg
I didn't use all of the information provided, just bands that are the most commonly used (and then some).

Please see Loom video for full explanation of choices made: https://loom.com/share/478b12c8873049819e26da1f4a90bc03

/* It is common to use 300 as an approximate conversion.
             * But since I'm not doing the math in my head, and I need to cite the formula, 
             * I may as well have my output be exact.
             * 
             * Citation:
             * How to Convert Wavelength In Metres to Megahertz. 
             * Convert wavelength in metres to megahertz. (n.d.). Retrieved November 6, 2022,
             * from https://www.unitconverters.net/frequency-wavelength/wavelength-in-metres-to-megahertz.htm 
 */

namespace Activity14_AaronStarley {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string band;
            int bandInt;
            string output;
            Double freq;
            
            band = listBox1.GetItemText(listBox1.SelectedItem);
            try {
                if (band[band.Length - 2] == 'c') band = band.Remove(band.Length - 2);
                if (band[band.Length - 1] == 'm') band = band.Remove(band.Length - 1);
                bandInt = Convert.ToInt32(band);
                freq = 299.792458 / bandInt;


                if (abbrevBox1.Checked) {
                    output = freq.ToString("n4");
                } else {
                    output = freq.ToString();
                }
                outputBox.Text = output;
            } catch {
                bandInt = 20;
                techRadioButton.Checked=true;
                outputBox.Text = "No band selected!";
            }


            if (techRadioButton.Checked) {
                if (bandInt == 70 || bandInt == 2 || bandInt == 6) {
                    privilegeInfo.Text = "All Privileges";
                    privilegeInfo.ForeColor = Color.Green;
                } else if (bandInt == 10) {
                    privilegeInfo.Text = "Some Privileges";
                    privilegeInfo.ForeColor = Color.DarkOrange;
                } else if (bandInt == 40 || bandInt == 80) {
                    privilegeInfo.Text = "CW Only";
                    privilegeInfo.ForeColor = Color.DarkOrange;
                } else {
                    privilegeInfo.Text="No Privileges!";
                    privilegeInfo.ForeColor = Color.Red;
                }
            }
            if(genRadioButton.Checked) {
                if (bandInt == 80 || bandInt == 40 || bandInt == 20) {
                    privilegeInfo.Text = "Some Privileges";
                    privilegeInfo.ForeColor = Color.DarkOrange;
                } else { 
                    privilegeInfo.Text="All Privileges";    
                    privilegeInfo.ForeColor = Color.Green;
                }
            }
            if(extraRadioButton.Checked) { 
                privilegeInfo.Text="All Privileges";
                privilegeInfo.ForeColor = Color.Green;
            }
        }

        private void verifyBox_CheckedChanged(object sender, EventArgs e) {
            if (verifyBox.Checked) {
                button1.Enabled = true;
            } else { 
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}