using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Project1.9\1) student.txt";
            try
            {

                Console.WriteLine("Student Data:");
                Console.WriteLine("-------------");
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}