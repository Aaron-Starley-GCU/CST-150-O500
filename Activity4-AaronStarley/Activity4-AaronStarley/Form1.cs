/*
 Aaron Starley
CST-150-O500

Syntax that was new to this assignment (TryParse) was learned in the text:
Gaddis, T. (2020). Starting out with Visual C#, 5/e. Pearson Education, Inc.

Besides that, everything below (that wasn't automatically inserted by Visual Studio)
is my own work.

 */

namespace Activity4_AaronStarley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            int minutes;
            int hours;
            int days;
            int userIn;
            if (!(int.TryParse(inputBox.Text, out userIn))||userIn<=0) {
                outputBox.Text = System.Convert.ToString("Please enter a positive integer");
            } else {
                if (userIn >= 86400) { //Finds number of days and gives formatted output
                    days = userIn / 86400;
                    outputBox.Text += System.Convert.ToString(days);
                    if (days > 1){
                        outputBox.Text += System.Convert.ToString(" Days");
                    } else {
                        outputBox.Text += System.Convert.ToString(" Day");
                    }
                    userIn -= 86400 * days; //subtracts days from user input
                    if (userIn > 0) {
                        outputBox.Text += System.Convert.ToString(", ");
                    }else{
                        outputBox.Text += System.Convert.ToString(" ");
                    }
                }
                if (userIn >= 3600){ //Finds number of hours and gives formatted output
                    hours = userIn / 3600;
                    outputBox.Text += System.Convert.ToString(hours);
                    if (hours > 1){
                        outputBox.Text += System.Convert.ToString(" Hours");
                    } else {
                        outputBox.Text += System.Convert.ToString(" Hour");
                    }
                    userIn -= 3600 * hours;//subtracts hours from user input
                    if (userIn > 0){
                        outputBox.Text += System.Convert.ToString(", ");
                    } else {
                        outputBox.Text += System.Convert.ToString(" ");
                    }
                }
                if (userIn >= 60){ //Finds number of minutes and gives formatted output
                    minutes = userIn / 60;
                    outputBox.Text += System.Convert.ToString(minutes);
                    if (minutes > 1){
                        outputBox.Text += System.Convert.ToString(" Minutes");
                    } else {
                        outputBox.Text += System.Convert.ToString(" Minute");
                    }
                    userIn -= 60 * minutes; //subtracts minutes from user input
                    if (userIn > 0){
                        outputBox.Text += System.Convert.ToString(", ");
                    } else {
                        outputBox.Text += System.Convert.ToString(" ");
                    }
                }
                if (userIn > 0) {
                    if(userIn > 1) { //Outputs remaining seconds
                    outputBox.Text += System.Convert.ToString(userIn + " Seconds");
                    } else { 
                    outputBox.Text += System.Convert.ToString(userIn + " Second");
                    }
                }
            }
            for (int i =0; i<10; i++) { 
                outputBox.Text += System.Convert.ToString(i);
            }
            
        }
    }
}