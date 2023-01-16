// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// https://leetcode.com/problems/detect-capital/description/

public class Solution
{
  public bool DetectCapitalUse(string word)
  {
    // scenario 1 - if first char is Upper, we have two possibility
    // possibility 1 - next all chars should be upper
    // possibility 2 - next all chars should be lower
    // scenario 2 - all chars should be lower


    // scenario 1 - if first char is Upper, we have two possibility
    var length = word.Length;
    if (length == 0 || length == 1) return true;
    if (char.IsUpper(word[0]))
    {
      //possibility 1 - next all chars should be upper
      //possibility 2 - next all chars should be lower
      bool isSecondCharUpper = char.IsUpper(word[1]);
      for (int i = 2; i < length; i++)
      {
        bool currentCharUpper = char.IsUpper(word[i]);
        if (isSecondCharUpper != currentCharUpper) return false;
      }
    }
    else
    {
      // scenario 2 - all chars should be lower
      for (int i = 1; i < length; i++)
        if (char.IsUpper(word[i])) return false;
    }

    return true;
  }
}