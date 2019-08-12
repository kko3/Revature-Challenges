using System;
using Palindrome.Domain;
using Xunit;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ThisIsAPalindrome()
        {
          CheckPalindrome palin = new CheckPalindrome("hannah");
          Assert.True(palin.isPalidrome());
        }
        [Fact]
        public void ThisIsNotAPalindrome()
        {
          CheckPalindrome palin = new CheckPalindrome("John");
          Assert.False(palin.isPalidrome());
        }
        [Fact]
        public void ThisSentenceIsAPalinDrome(){
          CheckPalindrome palin = new CheckPalindrome("MadamImAdam");
          Assert.True(palin.isPalidrome());
        }
        [Fact]
        public void CheckCapitalization(){
          CheckPalindrome palin = new CheckPalindrome("HAnnah");
          Assert.True(palin.isPalidrome());
        }
    }
}
