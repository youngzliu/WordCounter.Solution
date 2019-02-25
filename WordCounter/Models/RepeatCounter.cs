using System.Collections.Generic;

namespace WordCounter{
  public class RepeatCounter{
    private string MyWord;
    private string[] MySentence;

    public RepeatCounter(string word, string sentence){
      MyWord = word.ToLower();
      MySentence = sentence.Split(' ');
    }

    public string GetMessage(){
      if(MyWord.Split(' ').Length > 1){
        return "Please only enter one word to search for!";
      }
      else{
        int count = CountMatches();
        if(count == 0)
          return "No matches were found.";
        else if (count == 1)
          return "1 match was found.";
        else
          return count + " matches were found.";
      }
    }

    public int CountMatches(){
      int count = 0;
      foreach(string word in MySentence){
        if(word.ToLower() == MyWord)
          count++;
      }
      return count;
    }
  }
}
