// Define String.prototype.toAlternatingCase (or a similar function/method such as to_alternating_case/toAlternatingCase/ToAlternatingCase in your selected language; see the initial solution for details) such that each lowercase letter becomes uppercase and each uppercase letter becomes lowercase. For example:

// "hello world".ToAlternatingCase() == "HELLO WORLD"
// "HELLO WORLD".ToAlternatingCase() == "hello world"
// "hello WORLD".ToAlternatingCase() == "HELLO world"
// "HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
// "12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
// "1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
// "String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTERNATINGcASE"
// As usual, your function/method should be pure, i.e. it should not mutate the original string.

using System;

namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase (this string s)
    {
      string result ="";
      foreach(char c in s) {
        if(char.IsUpper(c)) {
          result += char.ToLower(c);
        } else if (char.IsLower(c)){
          result += char.ToUpper(c);
        } else result += c;
      }
      return result;
    }
  }
}