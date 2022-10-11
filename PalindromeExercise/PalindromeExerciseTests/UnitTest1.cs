using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("race car", true)]
        [InlineData("forking", false)]
        [InlineData("poop", true)]
        [InlineData("killa", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            WordSmith smith = new WordSmith();
            //Act
            bool actual = smith.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
