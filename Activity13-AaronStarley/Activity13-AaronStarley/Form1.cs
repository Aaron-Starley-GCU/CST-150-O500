/*
 Aaron Starley
 1-8-23
 CST-150-O500

The textbook said to have the x's and o's generated randomly, so there is the circumstance
that both x and o can win. If this is the case, the game tells the player "Draw (Both won?)".
This is simply to acknowledge the fact that both won, though this goes against the rules of
Tic-Tac-Toe.
 
 */



namespace Activity13_AaronStarley {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            resultBox.Text="Click 'New Game'";
        }

        private void newGameButton_Click(object sender, EventArgs e) {
            int[,] board = new int[3,3];
            //board[0,2] = 1;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    board[i,j]=random.Next(0,2);
                }
            }

            int oAcc=0;
            int xAcc=0;

            bool oWins = false;
            bool xWins = false;
            //Horizontal O
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    if (board[i, j] == 0) {
                        oAcc++;
                    }
                }
                if (oAcc == 3) { 
                    oWins = true;
                    break; 
                }
                oAcc=0;  
            }
            //Vertical O
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    if (board[j, i] == 0) {
                        oAcc++;
                    }
                }
                if (oAcc == 3) { 
                    oWins = true;
                    break; 
                }
                oAcc=0;  
            }

            //Horizontal X
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    if (board[i, j] == 1) {
                        xAcc++;
                    }
                }
                if (xAcc == 3) { 
                    xWins = true;
                    break; 
                }
                xAcc=0;  
            }
            //Vertical X
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    if (board[j, i] == 1) {
                        xAcc++;
                    }
                }
                if (xAcc == 3) {
                    xWins = true;
                    break;
                }
                xAcc = 0;
            }

            //Diagonals O
            for (int i = 0; i <= 2; i++) {
                if (board[i, i] == 0) {
                    oAcc++;
                }
            }
            if (oAcc == 3) {
                oWins = true;
            }
            oAcc=0;
            for (int i = 0; i <= 2; i++) {
                if (board[i, 2-i] == 0) {
                    oAcc++;
                }
            }
            if (oAcc == 3) {
                oWins = true;
            }

            //Diagonals X
            for (int i = 0; i <= 2; i++) {
                if (board[i, i] == 1) {
                    xAcc++;
                }
            }
            if (xAcc == 3) {
                xWins = true;
            }
            xAcc=0;
            for (int i = 0; i <= 2; i++) {
                if (board[i, 2-i] == 1) {
                    xAcc++;
                }
            }
            if (xAcc == 3) {
                xWins = true;
            }

            if (oWins) resultBox.Text="O Wins!";
            if (xWins) resultBox.Text="X Wins!";
            if(xWins && oWins) resultBox.Text="Draw (Both won?)";
            if(!xWins && !oWins) resultBox.Text="Draw (No winner)";
            
            
            
            char[,] boardText = new char[3,3];
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    if (board[i, j] == 0) {
                        boardText[i, j] = 'O';
                    } else if (board[i, j] == 1) {
                        boardText[i, j] = 'X';
                    }
                }
            }

            textBox00.Text = System.Convert.ToString(boardText[0,0]);
            textBox01.Text = System.Convert.ToString(boardText[0,1]);
            textBox02.Text = System.Convert.ToString(boardText[0,2]);
            
            textBox10.Text = System.Convert.ToString(boardText[1,0]);
            textBox11.Text = System.Convert.ToString(boardText[1,1]);
            textBox12.Text = System.Convert.ToString(boardText[1,2]);

            textBox20.Text = System.Convert.ToString(boardText[2,0]);
            textBox21.Text = System.Convert.ToString(boardText[2,1]);
            textBox22.Text = System.Convert.ToString(boardText[2,2]);
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}