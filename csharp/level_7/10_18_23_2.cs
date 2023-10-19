// Return the number (count) of vowels in the given string.

// We will consider a, e, i, o, u as vowels for this Kata (but not y).

// The input string will only consist of lower case letters and/or spaces.

using System;

public static class Kata
{
  public static int GetVowelCount(string str)
  {
    int vowelCount = 0;
    string vowels = "aeiou";

    var charArr = str.ToCharArray();

    foreach (char ch in charArr)
    {
      if (vowels.Contains(ch))
      {
        vowelCount++;
      }
    }

    return vowelCount;
  }
}