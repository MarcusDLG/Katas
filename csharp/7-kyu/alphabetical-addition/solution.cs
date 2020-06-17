using System;
using System.Linq;

public class Kata {
  public static char AddLetters(char[] letters) {
    if (letters.Count() ==0){
      return 'z';
    }
    var alphabet = "abcdefghijklmnopqrstuvwxyz";
    var sum = letters.Select(l => alphabet.IndexOf(l) +1).Sum();
    
    return alphabet[(sum - 1) % 26];
  }
}