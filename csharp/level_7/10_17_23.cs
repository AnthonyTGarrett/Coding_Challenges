// Task
// The year of 2013 is the first year after the old 1987 with only distinct digits.

// Now your task is to solve the following problem: given a year number, find the minimum year number which is strictly larger than the given one and has only distinct digits.

// Input/Output
// [input] integer year
// 1000 ≤ year ≤ 9000

// [output] an integer
// the minimum year number that is strictly larger than the input number year and all its digits are distinct

using System.Linq;
using System.Collections.Generic;

namespace myjinxin
{
  using System;

  public class Kata
  {
    public int DistinctDigitYear(int year)
    {
      for (int i = year + 1; i <= 9000; i++)
      {

        var numArr = i.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

        var numHash = new HashSet<int>(numArr);
        if (numHash.Count == 4)
        {
          return i;
        }
      }
      return -1;


    }
  }
}