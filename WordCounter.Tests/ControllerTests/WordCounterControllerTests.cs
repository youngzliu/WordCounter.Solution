using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests{
  [TestClass]
  public class WordControllerTest{
    [TestMethod]
    public void New_ReturnsCorrectViewType_True(){
      WordCounterController controller = new WordCounterController();
      ActionResult formView = controller.New();
      Assert.IsInstanceOfType(formView, typeof(ViewResult));
    }

    [TestMethod]
    public void Message_ReturnsCorrectViewType_True(){
      WordCounterController controller = new WordCounterController();
      ActionResult messageView = controller.Message();
      Assert.IsInstanceOfType(messageView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectViewType_True(){
      WordCounterController controller = new WordCounterController();
      ActionResult newCounterView = controller.Create("bob", "foo");
      Assert.IsInstanceOfType(newCounterView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_HasCorrectModelType_RepeatCounter(){
      WordCounterController controller = new WordCounterController();
      ViewResult newCounterView = controller.Create("bob", "foo") as ViewResult;
      var result = newCounterView.Model;
      Assert.IsInstanceOfType(result, typeof(RepeatCounter));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectView_Message(){
      WordCounterController controller = new WordCounterController();
      ViewResult newCounterView = controller.Create("bob", "foo") as ViewResult;
      var result = newCounterView.ViewName;
      Assert.AreEqual(result, "Message");
    }
  }
}
