/*
Aaron Starley  
12-18-2022
CST-150-O500 

I did all that work, then realized I'm only supposed to be writing stubs :)

 */

using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Activity9AaronStarley{
    public class Program { 
        public static void Main(string[] args) {  
            /*
            showMeters(10);// 0
            addTwoInts(12,5);// 1
            avgDoubles(5.4, 3.2, 1.0, 9.99, 7.5);// 2
            randIntSum();// 3
            bool x = divisByThree(1,1,1);// 4
            bool y = divisByThree(1,2,2);
            strFewestChars("Party on Wayne!", "Party on Garth!");// 5
            strFewestChars("What are you going to do today, Napoleon?","Whatever I feel like I wanna do, gosh!");
            double[] arrayX = { 5.0, 3.9, 3.5, 6.1, 7.8 };
            double largestDbl = largestDoubleInArray(arrayX); // 6
            Console.WriteLine(largestDbl);
            fiftyRandInts();// 7
            XNOR(false, false); // 8
            intDoubleProduct(5,3.2); // 9
            int[,] TwoD = { {1, 2, 3}, {3, 4, 9}, {7, 7, 0}, {1, 5, 6} };
            avgOf2DArray(TwoD); // 10
            */

            Console.WriteLine("Goodbye!");
        }

        public void showMeters(int numMillimeters) { } // 0
        public void addTwoInts(int x, int y) { } // 1
        public double avgDoubles(double a, double b, double c, double d, double e) { return 0.0; } // 2
        public int randIntSum() { return 0;} // 3
        public bool divisByThree(int x, int y, int z) { return false; } // 4
        public void strFewestChars(string x, string y) { } // 5
        public double largestDoubleInArray(double[] x) { return 0.0; } // 6
        public int[] fiftyRandInts() { // 7
            int[] x = new int[50];
            return x;}
        public bool XNOR(bool x, bool y) { return false; } // 8
        public double intDoubleProduct(int x, double y) { return 0.0; }// 9
        public  double avgOf2DArray(int[,] x) { return 0.0; }// 10

       /*
        public static void showMeters(int numMillimeters) { // 0
            Double meters = numMillimeters / 1000.0;
            Console.WriteLine(numMillimeters + "mm is "+ meters + "m.");
        }
        public static void addTwoInts (int x, int y) { // 1
            Console.WriteLine(x + "+" + y + "=" + (x+y));
        }
        public static double avgDoubles(double a, double b, double c, double d, double e) { // 2
            double average = (a + b + c + d + e) / 5;
            //Console.WriteLine("average: " + average);
            return average;
        }
        public static int randIntSum() { // 3
            //Learned how to get a random seed from here: https://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values
            Random rand= new Random(Guid.NewGuid().GetHashCode());
            int x = rand.Next();
            int y = rand.Next();
            //Console.WriteLine("Sum of two random ints= "+ (x+y));
            return (x+y);
        }
        public static bool divisByThree(int x, int y, int z) { // 4
            int sum = x + y + z;
            if (sum % 3 == 0) {
                //Console.WriteLine("Evenly Divis by 3");
                return true;
            } else {
                //Console.WriteLine("NOT evenly divis by 3");
                return false;
            }
        }
        public static void strFewestChars(string x, string y) { // 5
            int xLen = x.Length;
            int yLen = y.Length;
            if (xLen == yLen) { // Not part of the assignment, but this tells the user if the strings have the same length.
                Console.WriteLine("-Both strings have the same length-");
            } else if (xLen < yLen) {
                Console.WriteLine(x);
            } else if (xLen > yLen) { 
                Console.WriteLine(y);  
            }
        }
        public static double largestDoubleInArray(double[] x) { // 6
            //int largestIndex = 0;
            double largestValue = 0.0;
            for (int i = 0; i < x.Length; i++) {
                if (x[i] > largestValue) { 
                    largestValue = x[i];
                }
            }
            return largestValue;
        }
        public static int[] fiftyRandInts() { // 7
            int[] x = new int[50];
            //Learned how to get a random seed from here: https://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values
            Random rand= new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < x.Length; i++) {
                x[i]=rand.Next(); 
            }
            return x;
        }
        public static bool XNOR(bool x, bool y) { // 8
            if (x == y) {
                return true;
            } else { 
                return false; 
            }
        }
        public static double intDoubleProduct(int x, double y) { // 9
            return x * y;
        }
        public static double avgOf2DArray(int[,] x) { // 10
            int sum=0;
            for (int i = 0; i < x.GetLength(0); i++) {
                for (int j = 0; j < x.GetLength(1); j++) {
                    sum += x[i, j];
                }
            } 
            double avg = sum / (x.GetLength(0)*x.GetLength(1));
            //Console.WriteLine(avg);
            return avg;
        }
       */
    }
}