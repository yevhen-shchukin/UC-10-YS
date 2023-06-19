using UC10ConsoleApp.BL;
using UC10ConsoleApp.Tests;

Console.WriteLine("UC10 - START");

var uc10Tests = new Uc10Tests(new Uc10Bl());

uc10Tests.RunAllTests();