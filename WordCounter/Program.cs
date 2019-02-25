using System;
using System.Collections.Generic;

namespace WordCounter{
  public class Program{
    public static void Main(){
      Console.WriteLine("Please enter the sentence you would like to search through.");
      string sentence = Console.ReadLine();
      Console.WriteLine("Please enter the word you would like to search for in the sentence.");
      string word = Console.ReadLine();
      RepeatCounter rc = new RepeatCounter(word, sentence);
      Console.WriteLine(rc.GetMessage());
    }
  }
}
