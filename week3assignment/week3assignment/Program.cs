using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            uniqueWords("textfile.txt"); //call function and use the text file for it

            Console.ReadKey();
        }

        static void uniqueWords(string filename)
        {
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];
            BSTree<string> myTree = new BSTree<string>(); //create a tree of strings

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(filename);

            foreach (string line in AllLines)
            {
                //split words using space , . ? 
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');

                foreach (string word in words)
                {
                    //if myTree does not already have the word inserted and the word is not empty
                    if (!myTree.Contains(word.ToLower()) && word != "")
                    {
                        Console.WriteLine(word.ToLower()); //print the word to console
                        myTree.InsertItem(word.ToLower()); //add word to the tree
                    }
                }
            }
            //print height of the tree
            Console.WriteLine("Height of the tree: " + myTree.Height()); 

            //print the count of unique words in the tree
            Console.WriteLine("Number of unique words in the tree: " + myTree.Count()); 
        }
    }
}
