using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("*****FIRST ASSIGNMENT*****");
        int n;
        Console.WriteLine("Please enter a positive integer");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter " + n + " integer");
        int[] numbers = new int[n];
        for(int i = 0 ;i < n ;i++){
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        WriteEvens(numbers , n);
        Console.WriteLine("*****SECOND ASSIGNMENT*****");
        int a , b;
        Console.WriteLine("Please enter two integers");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter " + a + " integer");
        int[] secNumbers = new int[a];
        for(int i = 0 ;i < a ;i++){
        secNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        WriteDivisible(secNumbers , a , b);
        Console.WriteLine("*****THIRD ASSIGNMENT*****");
        Console.WriteLine("Please enter a positive integer");
        int c;
        c = Convert.ToInt32(Console.ReadLine());
        string[] words = new string[c];
        Console.WriteLine("Please enter " + c + " words");
        for(int i = 0 ;i < c ;i++){
        words[i] = Console.ReadLine();
        }
        Array.Reverse(words);
        Console.WriteLine("Array reversed");
        for(int i = 0 ;i < c ;i++){
                Console.Write(words[i] + " ");
        }
        Console.Write("\n");
        Console.WriteLine("*****FOURTH ASSIGNMENT*****");
        Console.WriteLine("Please enter a sentence");
        string? sentence = Console.ReadLine();
        string[] subArrs = sentence.Split(' ');
        int z = subArrs.Length;
        int NumOfChar = sentence.Length - (z-1);
        Console.WriteLine("Number of words is " + z + " and number of letters is " + NumOfChar);
         Console.WriteLine("*****DONE*****");

    }
    
      static public void WriteDivisible(int[] secNumbers , int a , int b)
      {
      Console.WriteLine("These can divide by " + b );
        for(int i = 0 ;i < a ;i++){
            if(secNumbers[i] % b == 0){
                Console.Write(secNumbers[i] + " ");
            }
        }
         Console.Write("\n");
      }
    static public void WriteEvens(int[] numbers , int n)
    {
        Console.WriteLine("These are the even integers ");
        for(int i = 0 ;i < n ;i++){
            if(numbers[i] % 2 == 0){
                Console.Write(numbers[i] + " ");
            }
        }
        Console.Write("\n");
    }
    }
}

