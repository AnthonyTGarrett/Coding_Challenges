// Create a function that takes 2 integers in form of a string as an input, and outputs the sum (also as a string):
using System;
namespace Solution
{
  public static class Program
  {
    public static string StringsSum(string s1, string s2)
    {
      int sum = 0;

      if (s1 == "")
      {
        s1 = "0";
      }
      if (s2 == "")
      {
        s2 = "0";
      }
      sum = Convert.ToInt32(s1) + Convert.ToInt32(s2);
      return Convert.ToString(sum);
    }
  }
}