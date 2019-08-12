using System;

namespace Palindrome.Domain
{
    public class CheckPalindrome
    {
      public string InputWord { get; set; }
      public bool isPalidrome(){
      
        for(int i = 0; i < InputWord.Length-1;i++){
          if(InputWord[i] != InputWord[(InputWord.Length-1)-i]){
            return false;
            break;
          }
        }

        return true;
      }

      public CheckPalindrome(string IWord){
        InputWord = IWord.ToLower();
      }
    }
}