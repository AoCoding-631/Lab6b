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

    
      //Desending
      Console.WriteLine("Desending order of odd numbers:");
      Array.Sort(OddNum);
      for(int pos=0; pos < len; pos++)
      {
        Console.WriteLine(OddNum[pos]);
      }
      
      //asending 
      Console.WriteLine("Asending order of even numbers: ");
      Array.Reverse(EvenNum);
      for(int pos=0; pos < len; pos++)
      {
        Console.WriteLine(EvenNum[pos]);
      }
  
        //find sum of even and odd numbers and display
        int sum1 = EvenNum.Sum();
        Console.WriteLine("Sum of even numbers = " + sum1);

        int sum2 = OddNum.Sum();
        Console.WriteLine("Sum of odd numbers = " + sum2);
        
  }
}