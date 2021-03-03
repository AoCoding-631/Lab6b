using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");


      int[] OddNum = {0,1,3,5,7,9,11,13,15,17,19};
      int[] EvenNum = {0,2,4,6,8,10,12,14,16,18};
    
      Console.WriteLine("Get number input");
      int num = Convert.ToInt32(Console.ReadLine());

      //length of odd and even numbers
      int len = OddNum.Length;
      Console.WriteLine("Length = " + len);
        
       len = EvenNum.Length;
      Console.WriteLine("Length = " + len);

      
      for(int pos=0; pos < len; pos++)
      {
        Console.WriteLine(EvenNum[pos]);
      }

      Console.WriteLine("Asending");
      Array.Sort(OddNum);
      for(int pos=0; pos > len; pos++)
      {
        Console.WriteLine(OddNum[pos]);
      }
      
      Console.WriteLine("Reverse");
      Array.Reverse(EvenNum);
      for(int pos=0; pos < len; pos++)
      {
        Console.WriteLine(EvenNum[pos]);
      }
    
        int min = OddNum.Min();
        Console.WriteLine("Min value = " + min);

        int max = EvenNum.Max();
        Console.WriteLine("Max value = " + max);
        //find sum of even and odd numbers and display
        int sum1 = EvenNum.Sum();
        Console.WriteLine("Sum = " + sum1);

        int sum2 = OddNum.Sum();
        Console.WriteLine("Sum = " + sum2);
        
  }
}