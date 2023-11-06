using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace ReadingAndWritingTextFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileToOpen = new StreamReader("U:/12c.txt");
            // read the contents to the console
            //Console.WriteLine(fileToOpen.ReadToEnd()); 

            // read the contents and store in string
            //string fileContents = fileToOpen.ReadToEnd(); 
            //Console.WriteLine(fileContents);

            // read a line of the file and output to the console
           // Console.WriteLine(fileToOpen.ReadLine());

            // read a line at a time and output to console
            //do
            //{
            //    Console.WriteLine(fileToOpen.ReadLine());
            //}while(!fileToOpen.EndOfStream); // not end of the file

            List<string> linesOfFile = new List<string>();
            do
            {
                linesOfFile.Add(fileToOpen.ReadLine());
            }while(!fileToOpen.EndOfStream);
            Console.WriteLine(linesOfFile.Count);
            Console.WriteLine(linesOfFile[0]);
            Console.WriteLine(linesOfFile[linesOfFile.Count-1]);

            fileToOpen.Close();
        }
    }
}
