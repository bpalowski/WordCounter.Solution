using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;//namespace cs//

using WordCounter;
namespace RepeatCounterT
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CheckingGetW()
    {
        //Arrange
      string testWord = "Tu";
      string testString = "Hola";
      counter newTest = new counter(testWord, testString);
      //Act
      string totalWord= newTest.GetWord();
      string totalString = newTest.GetString();
       //Assert
      Assert.AreEqual(testWord, totalWord);
      Assert.AreEqual(testString, totalString);
    }

    [TestMethod]
  public void TestTwo()
  {
    //Arrange
    string testingOne = "Good";
    string testingTwo = "Bye";
    counter newTest = new counter(testingOne, testingTwo);
//Act
    string totalWord = newTest.GetWord();
    string totalString = newTest.GetString();
    int total = newTest.WordTotal();
 //Assert
    Assert.AreEqual(testingOne, totalWord);
    Assert.AreEqual(testingTwo, totalString);
    Assert.AreEqual(0 , total);
  }


  }
}
