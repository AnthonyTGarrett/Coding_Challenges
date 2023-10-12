// Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no negative integers.


using System;

public static class Kata
{
  public static string CountSheep(int n)
  {
    string result = "";

    for (int i = 1; i <= n; i++)
    {
      result += $"{i} sheep...";
    }
    return result;
  }
}