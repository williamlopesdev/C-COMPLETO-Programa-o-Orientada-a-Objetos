using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                }
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //    using (StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }
                //    }
                //}
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
