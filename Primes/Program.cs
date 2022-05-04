using System;
using System.Collections.Generic;
using Primes;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please Enter a number");
    int number = int.Parse(Console.ReadLine());
    List<int> Sieves = PrimeSieve.ListOfNumbers(number);  
    List<int> SievesUpdate = PrimeSieve.SieveNumbers(Sieves);
    for (int i = 0; i < SievesUpdate.Count; i++)
    {
      Console.WriteLine(SievesUpdate[i].ToString());
    }
  }
}