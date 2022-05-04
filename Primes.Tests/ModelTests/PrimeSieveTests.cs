using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Primes;

namespace Primes.Tests
{
  [TestClass]
  public class PrimeSieveTests
  {
    [TestMethod]
    public void ListOfNumbers_GenerateListOfNumbers_List()
    {
    int number = 18;
    List<int> numbersList = PrimeSieve.ListOfNumbers(number);

    Assert.AreEqual(number-2, numbersList.Count);
    }

    [TestMethod]
    public void SieveNumbers_removesOneNumber_NumberList()
    {
      int number = 5;
      List<int> numbersList = PrimeSieve.ListOfNumbers(number);
      List<int> sievedList = PrimeSieve.ListOfNumbers(number);
      PrimeSieve.SieveNumbers(sievedList);
      numbersList.Remove(numbersList[2]);

      CollectionAssert.AreEqual(sievedList, numbersList);
    }

    [TestMethod]
    public void SieveNumbers_removesAllNonPrimes_NumberList()
    {
      int number = 20;
      List<int> numbersList = PrimeSieve.ListOfNumbers(number);
      List<int> sievedList = PrimeSieve.ListOfNumbers(number);
      PrimeSieve.SieveNumbers(sievedList);

      Assert.AreEqual(8, sievedList.Count);
    }
  }
}