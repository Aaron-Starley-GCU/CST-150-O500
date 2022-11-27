/* Aaron Starley
 * 11-6-22
 * CST 150-O500
 * 
 * All of the work below is my own, besides the formula needed to convert from meters to Megahertz.
 * I wanted to make sure my program was giving exact answers, so I looked up the exact conversion.
 */
namespace Activity2_AaronStarley
{
    public partial class Activity2 : Form
    {

        public Activity2()
        {
            InitializeComponent();
        }

        private void Activity2_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            /* It is common to use 300 as an approximate conversion.
             * But since I'm not doing the math in my head, and I need to cite the formula, 
             * I may as well have my output be exact.
             * TEST TEXT
             * Citation:
             * How to Convert Wavelength In Metres to Megahertz. 
             * Convert wavelength in metres to megahertz. (n.d.). Retrieved November 6, 2022,
             * from https://www.unitconverters.net/frequency-wavelength/wavelength-in-metres-to-megahertz.htm 
             */
            Double output = 299.792458 / Double.Parse(inputBox.Text);
            outputBox.Text = System.Convert.ToString(output);
        }
    }
}