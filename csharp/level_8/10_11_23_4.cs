// Write a function to split a string and convert it into an array of words.

namespace Solution
{
  using System;

  public class Solution
  {
    public static string[] StringToArray(string str)
    {
      return str.Split(" ");
    }
  }
}