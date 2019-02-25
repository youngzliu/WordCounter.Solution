using System.Collections.Generic;

namespace WordCounter{
  public class RepeatCounter{
    private string MyWord;
    private string[] MySentence;

    public RepeatCounter(string word, string sentence){
      MyWord = word;
      MySentence = sentence.Split(' ');
    }

    public string GetMessage(){
      if(MyWord.Split(' ').Length > 1){
        return "Please only enter one word to search for!";
      }
      else
        return "";
    }

  }
}
