using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };


            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };


            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };


            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };


            //--------------------
            //Bonus Problem 1
            string letters = "terrill";


        }
        public static Customer RunProblem4(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == 3)
                {
                    Console.WriteLine("Please write customer first name: ");
                    customer.FirstName = Console.ReadLine();
                    Console.WriteLine("Please write customer last name: ");
                    customer.FirstName = Console.ReadLine();
                    return customer;
                }
            }
            return null;
        }

        public static double RunProblem5(List<string> classGrades)
        {
            var classGrade = new List<double>();
            var studentGrade = new List<double>();
            foreach (string grades in classGrades)
            {
                string[] separateGrades = grades.Split(',');
                foreach (string separateGrade in separateGrades)
                {
                    studentGrade.Add(double.Parse(separateGrade));
                }
                studentGrade.Remove(studentGrade.Min());
                classGrade.Add(studentGrade.Average());
                studentGrade.Clear();
            }
            return classGrade.Average();
        }
        public static string RunBonusProblem1(string word)
        {
            var charList = word.ToList<char>();
            charList.Distinct


        }
    }
}
