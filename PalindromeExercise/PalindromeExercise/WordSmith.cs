﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public static bool IsAPalindrome(string word)
        {
            string reversedWord = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            if (word == reversedWord)
            {
                return true;

            }
            else { return false; }

        }
    }
}
