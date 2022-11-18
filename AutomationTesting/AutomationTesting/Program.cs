using AutomationTesting.Models;

NewMethod(); // I used refactoring

static void NewMethod()
{
    Class1.Test1("This is my first test");
    Class1.Test2("This is myFirstClass second test");

    var secondClass = new Class2();
    secondClass.SetValue(3);
    secondClass.GetValue();

    var secondClassVar = new Class2();
    secondClassVar.SetValue(0);
    secondClassVar.GetValue();

    secondClass.SetValue(-4);
    secondClass.GetValue();

    //explicit casting
    //object audiCar = new Audi();
    Audi.Warning();

    var newAudiCar = new Audi();
    Audi.Warning();
    newAudiCar.Color = "Audi";

    //((BMW)audiCar).Warning(); -> error

    // implicit casting-convertion
    short salary = 12344;
    int salaryIncrement = salary;
    salaryIncrement = 182293273; // no data loss

    //explicit convertion
    const double incomeTax = 33244.32221d;
    Console.WriteLine((int)incomeTax);//data loss

    Console.WriteLine(Toyota.Add(1, 3));
    Console.WriteLine(Toyota.Add(1, 2, 3));

    Toyota.Text();
    Console.WriteLine(Toyota.AudiCar(newAudiCar));
    Console.WriteLine(Toyota.ObjectExercise().GetType());
    Console.WriteLine(Toyota.DoubleTest());
    Console.WriteLine(Toyota.CarName());
    var audiC = Toyota.CarType();


    var bmw = new BMW();
    bmw.Check();

    var audi = new Audi();
    audi.Check();

    var toyota = new Toyota();
    toyota.Check();

    Audi.ForStatement();
    BMW.WhileStatement();
}
