using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests{
  [TestClass]
  public class WordControllerTest{
    [TestMethod]
    public void Form_ReturnsCorrectView_True(){
      WordCounterController controller = new WordCounterController();
      ActionResult formView = controller.Form();
      Assert.IsInstanceOfType(formView, typeof(ViewResult));
    }

    [TestMethod]
    public void Message_ReturnsCorrectView_True(){
      WordCounterController controller = new WordCounterController();
      ActionResult messageView = controller.Message();
      Assert.IsInstanceOfType(messageView, typeof(ViewResult));
    }
  }
}
