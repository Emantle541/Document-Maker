using System;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            bool DoAgain = true;
            while(DoAgain)
            {
                string moreDocuments;
                string Filename;
                string Fileinformation;
                Console.WriteLine("Document");
                try
                {
                    Console.WriteLine("Please enter the name of the document");
                    Filename = Console.ReadLine();
                    using(StreamWriter fileWriter = new StreamWriter($"{Filename}"))
                {
                    int i = 0;
                    int length = 1;
                    Console.WriteLine("Enter the content to be written to the document");
                    Fileinformation = Console.ReadLine();
                    fileWriter.WriteLine($"{Fileinformation}");
                    while (i <= Fileinformation.Length - 1)
                    {
                        if(Fileinformation[i]==' ' || Fileinformation[i]=='\n' || Fileinformation[i]=='\t')
                        {
                            length++;
                        }
                    i++;
                    }
                    Console.WriteLine($"{Filename} was successfully saved. The document contains {length} words.");

                }
                Console.WriteLine("Would you like to add more documents? (y/n)?");
                moreDocuments = Console.ReadLine();

                if(moreDocuments != "y" && moreDocuments != "Y")
                {
                    DoAgain = false;
                }
                }
                catch(Exception)
                {
                    Console.WriteLine("Error, please enter a document name.");
                }
            }
        }
    }
}
