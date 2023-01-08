/*
 Aaron Starley
 1-8-23
 CST-150-O500
 
 */



namespace Activity13_AaronStarley {
    public partial class Form1 : Form {
        char[,] board = new char[3,3];
        bool playerXTurn = false;
        bool oWins = false;
        bool xWins = false;
        int turns = 0;
        public Form1() {
            InitializeComponent();
            resultBox.Text="Click 'New Game'";
            
        }

        private void newGameButton_Click(object sender, EventArgs e) {
            playerXTurn = false;
            oWins = false;
            xWins = false;
            turns = 0;
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    board[i,j] = ' ';
                }
            }
            
            checkWinner();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void checkWinner() { 
            
            int oAcc=0;
            int xAcc=0;

            
            //Horizontal O
            for (int i = 0; i <= 2; i++) {
                for (int j = 0; j <= 2; j++) {
                    if (board[i, j] == 'O') {
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
                    if (board[j, i] == 'O') {
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
                    if (board[i, j] == 'X') {
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
                    if (board[j, i] == 'X') {
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
                if (board[i, i] == 'O') {
                    oAcc++;
                }
            }
            if (oAcc == 3) {
                oWins = true;
            }
            oAcc=0;
            for (int i = 0; i <= 2; i++) {
                if (board[i, 2-i] == 'O') {
                    oAcc++;
                }
            }
            if (oAcc == 3) {
                oWins = true;
            }

            //Diagonals X
            for (int i = 0; i <= 2; i++) {
                if (board[i, i] == 'X') {
                    xAcc++;
                }
            }
            if (xAcc == 3) {
                xWins = true;
            }
            xAcc=0;
            for (int i = 0; i <= 2; i++) {
                if (board[i, 2-i] == 'X') {
                    xAcc++;
                }
            }
            if (xAcc == 3) {
                xWins = true;
            }


            if (playerXTurn) {
                resultBox.Text = "X's Turn";
            } else { 
                resultBox.Text = "O's Turn";
            }
            if(turns == 9) resultBox.Text="Draw";
            if (oWins) resultBox.Text="O Wins!";
            if (xWins) resultBox.Text="X Wins!";
            

            button00.Text = System.Convert.ToString(board[0,0]);
            button01.Text = System.Convert.ToString(board[0,1]);
            button02.Text = System.Convert.ToString(board[0,2]);
            
            button10.Text = System.Convert.ToString(board[1,0]);
            button11.Text = System.Convert.ToString(board[1,1]);
            button12.Text = System.Convert.ToString(board[1,2]);

            button20.Text = System.Convert.ToString(board[2,0]);
            button21.Text = System.Convert.ToString(board[2,1]);
            button22.Text = System.Convert.ToString(board[2,2]);
        }



        private void button00_Click_1(object sender, EventArgs e) {
            if (board[0, 0] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[0, 0] = 'X';
                } else {
                    board[0, 0] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }
        private void button01_Click(object sender, EventArgs e) {
            if (board[0, 1] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[0, 1] = 'X';
                } else {
                    board[0, 1] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }

        private void button02_Click_1(object sender, EventArgs e) {
            if (board[0, 2] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[0, 2] = 'X';
                } else {
                    board[0, 2] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }

        private void button10_Click(object sender, EventArgs e) {
            if (board[1, 0] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[1, 0] = 'X';
                } else {
                    board[1, 0] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }

        private void button11_Click(object sender, EventArgs e) {
            if (board[1, 1] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[1, 1] = 'X';
                } else {
                    board[1, 1] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }

        private void button12_Click(object sender, EventArgs e) {
            if (board[1, 2] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[1, 2] = 'X';
                } else {
                    board[1, 2] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }

        private void button20_Click(object sender, EventArgs e) {
            if (board[2, 0] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[2, 0] = 'X';
                } else {
                    board[2, 0] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }

        private void button21_Click(object sender, EventArgs e) {
            if (board[2, 1] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[2, 1] = 'X';
                } else {
                    board[2, 1] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }

        private void button22_Click(object sender, EventArgs e) {
            if (board[2, 2] == ' ' && !xWins && !oWins) {
                if (playerXTurn) {
                    board[2, 2] = 'X';
                } else {
                    board[2, 2] = 'O';
                }
                playerXTurn = !playerXTurn;
                turns++;
                checkWinner();
            }
        }
    }
}