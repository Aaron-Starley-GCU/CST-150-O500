using System.Diagnostics;

namespace Activity11_AaronStarley
{
    public partial class Form1 : Form
    {
        Die die1 = new Die();
        Die die2 = new Die();
        int roll1;
        int roll2;
        bool snakeEyes = false;
        int numberOfRolls = 0;
        public Form1()
        {
            InitializeComponent();
            dieTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            dieTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.richtextbox.selectionalignment?view=netframework-4.6
            //I wanted to have the text centered in my RichTextBoxes, and couldn't find alignment in Properties.
        }
        private void rollButton_Click(object sender, EventArgs e)
        {
            roll1 = die1.rollDie();
            dieTextBox1.Text=System.Convert.ToString(roll1);
            roll2 = die2.rollDie();
            dieTextBox2.Text=System.Convert.ToString(roll2);
            dieTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            dieTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            numberOfRolls++;
            if((roll1 == 1)&&(roll2 == 1)){ 
                snakeEyes = true;
                MessageBox.Show("It took " + numberOfRolls +" rolls to get snake eyes!");
                //numberOfRolls = 0; //This was used before "Environment.Exit(0);" was implemented.
                Application.Exit();//https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.application.exit?view=windowsdesktop-7.0
            }
        }
        private void Form1_Load(object sender, EventArgs e){}
        public class Die { 
            private int numOfSides;
            private int rolledSide = 1;

            public Die(int numS)
            {
                numOfSides = numS;
                if(numOfSides < 3 || numOfSides > 20) { 
                    numOfSides = 6;   
                }
            }
            public Die() { 
                numOfSides = 6;   
            }
            public int rollDie() { 
                //Learned how to get a random seed from here: https://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values
                Random roller= new Random(Guid.NewGuid().GetHashCode());
                rolledSide = roller.Next(1,numOfSides+1);
                return rolledSide;
            }
            public int readRoll() { 
                return rolledSide;    
            }
        }
    }   
}