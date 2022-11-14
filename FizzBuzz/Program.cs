
// Write a public method that accepts a number
//1. Access Modifier
//2. Return Type
//3. Method Name
//4. Parameters
//5. Scope
//can i assume that number is an integer? or is it a double?
using System;

namespace Fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"{i}: {FizzBuzz(i)}");
        }
    }

    //access modifier / return type / method name / parameters
    public static string FizzBuzz(int number)
    { //scope
        var answer = "";
        // when the number is divisible by 3 return the word fizz
        if (number % 3 == 0)
        {
            answer = "fizz";
        }

        if (number % 5 == 0)
        {
            answer += "buzz"; //answer = answer + "buzz"
        }

        return answer;
        // when the number is divisible by 5 return the word buzz

        // when the number is divisible by both, return the word fizzbuzz

    } //scope
}