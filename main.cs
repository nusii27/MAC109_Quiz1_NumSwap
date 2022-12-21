using System;

class Program {
  
  public static void Main (string[] args) {

    int num1, num2;
    
    Console.WriteLine("Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the scond number: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Before Swapping: ");
    Console.WriteLine("First number is: " + num1);
    Console.WriteLine("Second number is: " + num2);

    Swap(ref num1, ref num2);

    Console.WriteLine("After Swapping: ");
    Console.WriteLine("First number is now: " + num1);
    Console.WriteLine("Second number is now: " + num2);
  
    void Swap(ref int num1, ref int num2) {
    int temp = num1;
    num1 = num2;
    num2 = temp;
    }
  }
}