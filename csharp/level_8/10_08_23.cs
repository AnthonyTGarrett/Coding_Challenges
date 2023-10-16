// Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, including them.

using System.Collections.Generic;

public class Kata
{
  public static int[] Between(int a, int b)
  {
    List<int> result = new List<int>();

    for (int i = a; i <= b; i++)
    {
      result.Add(i);
    }

    return result.ToArray();
  }
}