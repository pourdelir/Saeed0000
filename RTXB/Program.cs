using System;
using System.IO;


namespace RTXB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read TXT");
            Console.WriteLine("Enter name and path of the text file")
            Console.WriteLine("How many lines of the text file you'd like to stream? 0 : entire file.");
            int lines = Convert.ToInt16( Console.ReadLine());
            
            using (StreamReader sr = new StreamReader(@"E:\Download\pwned-passwords-sha1-ordered-by-count-v8\pwned-passwords-sha1-ordered-by-count-v8.txt"))
            {

                String line;
                // Read line by line 
                int row = 1;

                    // while ((line = sr.ReadLine()) != null) 
                    while (row<100) 

                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                    row++;

                }
            }
            Console.ReadKey();
        }
    }
}
