using System;
using System.Collections.Generic;

public class Palidrome 
{
  public static void Main()
  {
    Console.WriteLine("Please enter a word uwu");
    string userEntry = Console.ReadLine();
    char[] arrPhrase = userEntry.ToCharArray();
    int backwardsIndex = arrPhrase.Length - 1;

    bool truePalindrome = true;
    foreach(char character in arrPhrase)
    {
      if (Char.ToUpper(arrPhrase[backwardsIndex]) != Char.ToUpper(character)) {
        Console.WriteLine(arrPhrase[backwardsIndex] + " != " + character);
        truePalindrome = false;
        break;
      }
      backwardsIndex -= 1;
    }
    if (truePalindrome) {
      Console.WriteLine("gee whizz this is a palindrome");
    } else {
      Console.WriteLine("we can't all be racecars");
    }
  }
}