using System;
using Xunit;
using PalindromeExerciseTests;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("wow", true)]
        [InlineData("kal", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var wordsmith = new WordSmith();

            var actual = WordSmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
