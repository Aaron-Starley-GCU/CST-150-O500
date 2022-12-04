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
             * 
             * Citation:
             * How to Convert Wavelength In Metres to Megahertz. 
             * Convert wavelength in metres to megahertz. (n.d.). Retrieved November 6, 2022,
             * from https://www.unitconverters.net/frequency-wavelength/wavelength-in-metres-to-megahertz.htm 
             */
            /* Notes for Activity 6: Using code used in Activity 4, I added error handling functionality to
             * my program from Activity 2. Only positive numbers are allowed. These inputs are taken as a Double
             * since someone might want to know what MHz the 70cm band is, which would be input as "0.7" meters.
             * Then using the textbook, I found how to format the output so that it was rounded to 3 decimal places.
             * I know that this can be done using only one line of code (see the commented out line below), but decided
             * to store the formatted output in a variable.
             */

            Double output;
            if(Double.TryParse(inputBox.Text, out output) && output >= 0) { 
                output = 299.792458 / Double.Parse(inputBox.Text);
               String formattedOutput = output.ToString("n3");
               outputBox.Text = formattedOutput;
               //outputBox.Text = output.ToString("n3"); //See comments above.
            } else { 
                outputBox.Text = "Invalid input";
            }
        }
    }
}