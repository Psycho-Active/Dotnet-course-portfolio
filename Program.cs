// This is a Todo list application for learning purposes

using System.Runtime.InteropServices;

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

// Get user input
var userChoice = Console.ReadLine();

var result = Add(10, 5);
Console.WriteLine("10 + 5 = " + result);

// Create a method that prints the user selection
void printSelectedName(string selectedOption)
{
  Console.WriteLine("Selected Option: " + selectedOption);
}

// Create a method that will add two integers together
int Add(int a, int b)
{
  return (a + b);
}

// wait for user to input random character to end program
Console.ReadKey();