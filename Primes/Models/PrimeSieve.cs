using System.Collections.Generic;

namespace Primes
{
  public class PrimeSieve
  {
    private static List<PrimeSieve> _numbers = new List<PrimeSieve> {};

    public static List<int> ListOfNumbers(int number)
    {
      List<int> numbersList = new List<int>() {};
      for (int i = 2; i < number; i++)
      {
        numbersList.Add(i);
      }
      return numbersList;
    }

    public static List<int> SieveNumbers(List<int> numbersList)
    {
      for (int i = 0; i < numbersList.Count; i++)
      {
        for (int j = 0; j < numbersList.Count; j++)
        {
          if (numbersList[j] != numbersList[i] && numbersList[j] % numbersList[i] == 0) 
          {
            numbersList.Remove(numbersList[j]);
          }
        }
        
      }
      return numbersList;
    }
  }
}