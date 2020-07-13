using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TxtToCSVImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] arStr = File.ReadAllLines("C:\\1.txt");
            string[] final = new string[arStr.Length/3] ;
            int count = 0, index = 0;
            for(int i = 0; i < arStr.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    count = 0;
                    index++;
                }
                if (count == 2)
                    final[index] += arStr[i];
                else
                    final[index] += arStr[i] + ",";
                
                count++;
            }

            using (StreamWriter sw = new StreamWriter("C:\\some.txt", true))
            {
                for (int i = 0; i < final.Length; i++)
                    sw.WriteLine(final[i]);
                sw.Close();
            }

            
            Console.ReadLine();
        }
    }
}
