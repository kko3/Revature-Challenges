using System;
using Palindrome.Domain;
using Palindrome.Test;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPalindrome palinD = new CheckPalindrome("hannah");
            palinD.isPalidrome();
        }
    }
}
