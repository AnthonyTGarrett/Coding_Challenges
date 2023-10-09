// Given an array of integers.

// Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

// If the input is an empty array or is null, return an empty array.

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] CountPositivesSumNegatives(int[] input)
  {
    if (input == null || input.Length == 0)
    {
      return new int[0];
    }

    int[] result = new int[2];

    foreach (int el in input)
    {
      if (el > 0)
      {
        result[0]++;
      }
      else if (el < 0)
      {
        result[1] += el;
      }
      else
      {
        continue;
      }
    }
    return result;
  }
}