// See https://aka.ms/new-console-template for more information
using System;
int a = 3;
int b = a++;
Console.WriteLine($"a is {+a++}, b is {-++b}");
int c = 3;
int d = ++c;
Console.WriteLine($"c is {-c--}, d is {~d}");
