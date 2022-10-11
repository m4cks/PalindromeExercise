using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            string baseCheck = "";
            string check = "";
            for(int i = 0; i < str.Length; i++)
            {
                if(Char.IsLetter(str[i]) || Char.IsDigit(str[i]))
                    baseCheck += str[i];
                if(Char.IsLetter(str[(str.Length - 1 - i)]) || Char.IsDigit(str[(str.Length - 1 - i)]))
                    check += str[(str.Length - 1 - i)].ToString();
            }
            if(baseCheck == check)
            {
                return true;
            }
            return false;
        }
    }
}
