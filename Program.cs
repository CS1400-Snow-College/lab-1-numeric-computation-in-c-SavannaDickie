﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient; {d}");
Console.WriteLine($"remainder: {e}");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
int what = max + 3;
Console.WriteLine($"An example of overflow; {what}");
