using PalindromeExercise;
using System;
using Xunit;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        
        public class Test1
        {
            [Theory]
            [InlineData("racecar", true)]
            [InlineData("hello", false)]
            [InlineData("Racecar", true)]
            public void MyTest(string word, bool expected)
            {
                //Arrange
                var tester = new WordSmith();

                //Act
                var actual = tester.Palindrome(word);

                //Assert
                Assert.Equal(expected, actual);
            }
        }
    }
}
