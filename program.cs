using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document Merger");
            bool program = true;
            while (program == true)
            {
                Console.WriteLine("Enter the name of the first document: ");
                string document1 = Console.ReadLine();
                while (document1.Length == 0)
                {
                    Console.WriteLine("File does not exist. Please re-enter document name:");
                    document1 = Console.ReadLine();
                }
                Console.WriteLine("Enter the name of the second document: ");
                string document2 = Console.ReadLine();
                while (document2.Length == 0)
                {
                    Console.WriteLine("File does not exist. Please re-enter document name:");
                    document2 = Console.ReadLine();
                }
                string mergedDocument = document1 + document2 + ".txt";
                Console.WriteLine("Would you like to merge two more file? y/n");
                string again = Console.ReadLine();
                try{
                    string mergedText = System.IO.File.ReadAllText(document1);
                    mergedText += "\r\n";
                    mergedText += System.IO.File.ReadAllText(document2);
 
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error writing to {0}: {1}", mergedDocument, e.Message);
                }
                if (again == "n")
                {
                    program = false;
                }
            }


        }
    }      
}
