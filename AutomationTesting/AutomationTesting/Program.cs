// See https://aka.ms/new-console-template for more information
using AutomationTesting;

Console.WriteLine("Hello, World!");

NewMethod(); // I used refactoring

static void NewMethod()
{
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

    //explicit casting

    object audiCar = new Audi();
    ((Audi)audiCar).Warning();  

    var newAudiCar = new Audi();   
    newAudiCar.Warning();
    newAudiCar.Color = "Audi";

    //((BMW)audiCar).Warning();

    // implicit casting-convertion
    Int16 salary = 12344;
    int salaryIncrement = salary;
    salaryIncrement = 182293273; // no data loss

    //explicit convertion
    double incomeTax = 33244.32221d;
    Console.WriteLine((int)incomeTax);//data loss

    var toyotaCar = new Toyota();  
    Console.WriteLine(toyotaCar.Add(1, 3));
    Console.WriteLine(toyotaCar.Add(1, 2, 3));

    toyotaCar.Text();
    Console.WriteLine(toyotaCar.AudiCar(newAudiCar)); 
    Console.WriteLine(toyotaCar.ObjectExercise().GetType()); 
    Console.WriteLine(toyotaCar.DoubleTest());
    Console.WriteLine(toyotaCar.CarName());
    var audiC = toyotaCar.CarType();


    var bmw = new BMW();
    bmw.Check();

    var audi = new Audi();
    audi.Check();

    var toyota = new Toyota();
    toyota.Check();

    audi.ForStatement();
    bmw.WhileStatement();
}

   


