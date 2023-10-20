// Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int SumDigits(int number)
  {
      var newNum = Math.Abs(number);
      var intList = newNum.ToString().Select(x => Convert.ToInt32(x.ToString())).ToList();
      return intList.Aggregate((a,b) => a + b);
  }
}