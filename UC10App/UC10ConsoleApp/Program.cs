// See https://aka.ms/new-console-template for more information
using UC10ConsoleApp.BL;

Console.WriteLine("UC10 - START");

var ucBl = new Uc10Bl();

var inputString = "Lore7$Psum";

var result = ucBl.RegExTest(inputString, 10);

Console.WriteLine($"Result: {result}");

