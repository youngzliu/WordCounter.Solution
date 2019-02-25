using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests{
  [TestClass]
  public class RepeatCounterTest{

    [TestMethod]
    public void GetMessage_NotOneWord_ErrorMessage(){
      RepeatCounter rc = new RepeatCounter("bla bla", "the quick brown fox");
      string message = rc.GetMessage();
      Assert.AreEqual("Please only enter one word to search for!", message);
    }

    [TestMethod]
    public void GetMessage_NoMatches_NoMatchesMessage(){
      RepeatCounter rc = new RepeatCounter("foo", "the quick brown fox jumped over the lazy dog.");
      string message = rc.GetMessage();
      Assert.AreEqual("No matches were found.", message);
    }

    [TestMethod]
    public void GetMessage_OneMatch_OneMatchMessage(){
      RepeatCounter rc = new RepeatCounter("foo", "the quick brown foo jumped over the lazy dog.");
      string message = rc.GetMessage();
      Assert.AreEqual("1 match was found.", message);
    }

    [TestMethod]
    public void GetMessage_MultipleMatches_FourMatchesMessage(){
      RepeatCounter rc = new RepeatCounter("foo", "the quick foo jumped over the foo foo foo");
      string message = rc.GetMessage();
      Assert.AreEqual("4 matches were found.", message);
    }

    [TestMethod]
    public void GetMessage_IgnoresCase_TwoMatchesMessage(){
      RepeatCounter rc = new RepeatCounter("FOO", "the quick brown foo jumped over the foo dog.");
      string message = rc.GetMessage();
      Assert.AreEqual("2 matches were found.", message);
    }
  }
}
