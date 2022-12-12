/*
Aaron Starley  
12-11-2022
CST-150-O500 
 */
namespace Activity8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double userIn;
            Double output=0;
            if(Double.TryParse(inputBox.Text, out userIn) && userIn > 0) { 
                
                if(radioButton1.Checked == true) { //Fat grams to Calories
                    output = FatCalories(userIn);
                    outputLabel.Text="Calories from fat";
                } else if (radioButton2.Checked == true){                           //Carb grams to Calories
                    output = CarbsCalories(userIn);
                    outputLabel.Text="Calories from carbs";
                }
            outputBox.Text = System.Convert.ToString(output);

            } else { 
                outputBox.Text = "Invalid input";
            }
        }
        static Double FatCalories(Double input) {
            return (Double) input * 9;
        }
        static Double CarbsCalories(Double input) {
            return (Double) input * 4;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            inputLabel.Text = "Grams of fat";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            inputLabel.Text = "Grams of carbs";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}