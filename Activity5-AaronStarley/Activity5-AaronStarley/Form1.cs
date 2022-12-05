/*
 Aaron Starley
 12-4-22
 CST-150-O500

Of the three activities for this week, this was by far the most difficult.
What I couldn't find in the text was how to split a string into substrings
by a character ([SPACE] for instance). I was however, able to find how to
here:https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
Everything else is either from the text, or is my own original work.

The "Tears in Rain" speech I used in the screenshot is from the
1982 film "Blade Runner". (Don't know if that matters, but I don't
want to lose points on a technicality.)
 
 */
using System.Collections.Immutable;
using System.Runtime.ExceptionServices;

namespace Activity5_AaronStarley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileLabel.Text = openFileDialog1.FileName;
                string textFromFile;
                StreamReader inputFile;
                
                inputFile = File.OpenText(fileLabel.Text);
                textFromFile = inputFile.ReadLine();
                
                
                StreamWriter outputFile;
                outputFile = File.CreateText("Actvity5-Output.txt");
                outputFile.WriteLine();

                string[] words = textFromFile.Split(' ');//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
                                                         
                for(int i = 0; i < words.Length; i++) { //Converting all words to lower case.
                    words[i] = words[i].ToLower();
                    outputBox.Text += System.Convert.ToString(words[i] +" ");
                }
                outputFile.WriteLine(outputBox.Text);
                outputBox.Text += System.Convert.ToString("\n");

                //Finding first and last words alphabetically by looking at the first char of each word.
                char[] firstLetters = new char[words.Length]; 
                int smallest=999;
                int smallestIndex=0;
                int largest=0;
                int largestIndex=0;
                for(int i = 0; i < words.Length; i++) {
                    firstLetters[i] = words[i][0];
                    if (firstLetters[i] < smallest) { 
                        smallest = firstLetters[i];
                        smallestIndex = i;
                    }
                    if (firstLetters[i] > largest){
                        largest = firstLetters[i];
                        largestIndex = i;
                    }
                }
                outputBox.Text += System.Convert.ToString("Alphabetically First: " + words[smallestIndex])+"\n";
                outputBox.Text += System.Convert.ToString("Alphabetically Last: "+ words[largestIndex])+"\n";
                outputFile.WriteLine(System.Convert.ToString("Alphabetically First: " + words[smallestIndex]));
                outputFile.WriteLine(System.Convert.ToString("Alphabetically Last: " + words[largestIndex]));

                //Finding the longest word.
                int longestIndex = 0;
                int longest = 0;
                for(int i = 0; i < words.Length; i++) { 
                    if (words[i].Length > longest) {
                        longest= words[i].Length;
                        longestIndex = i;
                    }
                }
                outputBox.Text += System.Convert.ToString("Longest word: " + words[longestIndex])+"\n";
                outputFile.WriteLine(System.Convert.ToString("Longest word: " + words[longestIndex]));

                //Finding the word with the most vowels.
                int vowels;
                int mostVowels = 0;
                int mostVowelsIndex=0;
                for(int i = 0; i < words.Length; i++) { 
                    vowels = 0;
                    for(int j = 0; j < words[i].Length; j++) {
                        Char currentChar = System.Convert.ToChar(words[i][j]);
                        if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u') { 
                            vowels++;
                        }
                    }    
                    if (vowels > mostVowels) {
                        mostVowels = vowels;
                        mostVowelsIndex = i;
                    }
                }
                outputBox.Text += System.Convert.ToString("Word with most vowels: "+ words[mostVowelsIndex])+"\n";
                outputFile.WriteLine(System.Convert.ToString("Word with most vowels: "+ words[mostVowelsIndex]));
                inputFile.Close();
                outputFile.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}