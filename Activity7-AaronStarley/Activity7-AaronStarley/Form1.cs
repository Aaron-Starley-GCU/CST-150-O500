namespace Activity7_AaronStarley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int userIn;
            Double output = 4.0;
            bool add = false; //used for flip-flopping between adding and subtracting.
            if(int.TryParse(inputBox.Text, out userIn) && userIn > 0) { //Making sure input is valid. If it is invalid, it will NOT show the user an error, it will simply do nothing.
                /*For-loop used to calculate pi given the number of terms. We started with 4, 
                 * then alternate between adding and subtracting 4/(1+(i*2)), as per the
                 * sequence given in the assignment. If i=1, then 4/(1+(i*2)) = 4/3. */
                for(int i = 1; i < userIn; i++){
                    if (add) { 
                        output += 4.0/(1.0+(i*2.0));
                        add = false;
                    } else { 
                        output -= 4.0/(1.0+(i*2.0));
                        add = true;
                    }
                }
                //Giving output as per the assignment guidelines.
                outputText1.Text = "Approximate value of pi after " + System.Convert.ToString(userIn) + " terms.";
                outputText2.Text = "=" + System.Convert.ToString(output);
            }
        }
    }
}