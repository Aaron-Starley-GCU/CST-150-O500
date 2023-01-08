/*
Aaron Starley
1-6-23
CST-150-O500


 */

using System.Collections.Immutable;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Activity12_AaronStarley {
    public class Program {
        public static void Main(string[] args) {
            string textFromFile;
            StreamReader inputFile;
            inputFile = File.OpenText("test.txt");//placeholder file name
            textFromFile = inputFile.ReadToEnd();
            
            string[] words = textFromFile.Split(' ',',','.','!','?');
            
            Console.WriteLine(textFromFile);
            for (int i = 0; i < words.Length; i++) {
                words[i] = words[i].ToLower();
            }
            
            char[] lastLetters = new char[words.Length];
            for (int i = 0; i < words.Length; i++) {
                try {
                    lastLetters[i] = words[i][words[i].Length-1];
                } catch { 
                    lastLetters[i] = ' ';
                }
            }
            int acc=0;
            for (int j = 0; j < lastLetters.Length; j++) { 
                if(lastLetters[j] == 't' || lastLetters[j]=='e') {
                    acc++;
                }
            }
            Console.WriteLine("There were " + acc + " words that ended with t or e.");

            // Clean-up
            inputFile.Close();
        }   
    }
}