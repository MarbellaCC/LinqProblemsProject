using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25
       
        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            List<string> stringsThatContainTH = words.Where(s => s.Contains("th")).ToList();
            //return
            return stringsThatContainTH;
        }
        #endregion
         

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            List<string> distinctNames = names.Distinct().ToList();
            //return
            return distinctNames;
        }
        #endregion
        

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            Customer loneCustomer = customers.First(c => c.FirstName.Contains("Mike"));    //maybe .Single?
            //return
            return loneCustomer;
        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            Customer CustomerID3 = customers.Find(c => c.Id == 3);
            Console.WriteLine("Please write customer first name: ");
            CustomerID3.FirstName = Console.ReadLine();
            Console.WriteLine("Please write customer last name: ");
            CustomerID3.LastName = Console.ReadLine();
            return CustomerID3;

        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            var classGrade = new List<double>();            

            for (int i = 0; i < classGrades.Count; i++)
            {
                var studentGrade = new List<double>();
                var SeparatedStudentStringGrade = new List<string>(classGrades[i].Split(','));
                SeparatedStudentStringGrade.ForEach(separateGrade => studentGrade.Add(double.Parse(separateGrade)));
                studentGrade.Remove(studentGrade.Min());
                classGrade.Add(studentGrade.Average());
            }
            return classGrade.Average();
        }
        #endregion

        #region Bonus Problem 1
        //(5 points) Bonus Problem 1
        //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        public static string RunBonusProblem1(string word)
        {
            var characters = word.ToArray();
            Array.Sort(characters);
            var alphabetizedList = characters.ToList();
            var alphabetizedShorList = characters.ToList().Distinct().ToList();
            var completedList = new List<string>();
            for (int i = 0; i < alphabetizedShorList.Count; i++)
            {
                int x = 0;

                for (int j = 0; j < alphabetizedList.Count; j++)
                {
                    if (alphabetizedShorList[i] == alphabetizedList[j])
                    {
                        x++;
                    }
                }
                completedList.Add(alphabetizedShorList[i].ToString());
                completedList.Add(x.ToString());
            }
            string finalString = "";
            completedList.ForEach(s => finalString += s);
            return finalString;
        }
        #endregion
    }
}
