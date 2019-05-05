using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9StudentInfoLists
{
    class AddStudent
    {
        public static string ValidateNewStudent(string message)
        {
            string word = Console.ReadLine();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine(message);
                return ValidateNewStudent(message);
            }
            else
            {
                return word;
            }
        }
    }
}
