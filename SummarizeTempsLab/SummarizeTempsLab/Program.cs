using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            string filename;
            Console.WriteLine("Enter file name");
            filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                Console.WriteLine("file exists");
                //ask user to enter temperature
                Console.WriteLine("Enter treshold");
                string input;
                input = Console.ReadLine();
                int threshold = int.Parse(input);


                int sumTemps = 0;
                int numabove = 0;
                int numbelow = 0;


                //open file and create stream reader
                // read a line into the string variable
                using (StreamReader sr = File.OpenText(filename))
                {
                    string line = sr.ReadLine();
                    int temp;

                    while (line != null)
                    {
                        temp = int.Parse(line);
                        sumTemps += temp;
                        if (threshold <= temp) 
                        {
                            numabove += 1;

                        }
                        else
                        {
                            numbelow += 1;
                        }

                        line = sr.ReadLine();

                    }
                    Console.WriteLine("number of temperatures above the treshold are" + numabove);
                    Console.WriteLine("number of temperatures below the treshold are" + numbelow);
                    int average;
                    average = sumTemps / (numabove + numbelow);
                    Console.WriteLine("Average is " + average);



                        





                }


            }
            
           

        }
    }
}
