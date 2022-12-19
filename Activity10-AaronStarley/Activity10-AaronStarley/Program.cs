/*
 Aaron Starley
 12-18-22
 CST 150-O500

I did not end up using breakpoints at all because I encountered
no errors that caused crashes.
 */

//Corrected by Aaron Starley

//User for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args) 
        { 
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: "+A);
            Console.WriteLine("B: "+B);
        }
    }
    class Set 
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if(containsElement(val)) return false;
            else 
            {
                elements.Add(val);
                return true;
            }
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if(val == elements[i]) 
                    return true;
                //else
                //    return false;
                //Shouldn't return false yet. The way it was written, the for loop would exit if the first element wasn't unique. We need check them all.
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements) 
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            Set temp = new Set(); //Created temporary Set so we aren't modifying A or B later.

            for(int i = 0; i < rhs.elements.Count; i++)
            {
                //this.addElement(rhs.elements[i]);
                //We don't want to modify this Set. Modifying temp instead.
                temp.addElement(rhs.elements[i]);
            }
            for(int j = 0; j < this.elements.Count; j++)
            {
                temp.addElement(this.elements[j]);
                //This adds "this" set into temp.
            }
            //I understand why "this.addElement(rhs..." simplifies things, but we don't want to
            // modify "this" Set. We just want a copy of the data in it.

            //return rhs;
            //This would have returned Set B without making any changes. We want to return
            //the Set 'temp', not our original input Set.
            return temp;
        }
    }
}