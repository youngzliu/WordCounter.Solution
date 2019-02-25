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
  }
}
