// See https://aka.ms/new-console-template for more information
using AutomationTesting;

Console.WriteLine("Hello, World!");


Class1 myFirstClass = new Class1();
myFirstClass.Test1("This is my first test");
myFirstClass.Test2("This is myFirstClass second test");

Class2 secondClass = new Class2();
secondClass.SetValue(3);
secondClass.GetValue();

Class2 secondClassVar = new Class2();
secondClassVar.SetValue(0);
secondClassVar.GetValue();

secondClass.SetValue(-4);
secondClass.GetValue();

object audiCar = new Audi();
((Audi)audiCar).Warning();
((BMW)audiCar).Warning(); /// ??