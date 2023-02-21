using AutomationTesting.Browsers;
using AutomationTesting.Models;
using AutomationTesting.Selenium;
using System.Collections;
using System.Collections.Generic;

//NewMethod(); // I used refactoring
//ArraysExcercises();
//CollectionsExercises();
GenericCollectionsWithCustomType();
EnumsEx();

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
    Toyota.CarType();


    var bmw = new BMW();
    bmw.Check();

    var audi = new Audi();
    audi.Check();

    var toyota = new Toyota();
    toyota.Check();

    Audi.ForStatement();
    BMW.WhileStatement();
}
static void Exercises()
{
    //DataTypesExercises.ReverseChar();
    //DataTypesExercises.CheckVowels();
    //DataTypesExercises.CheckIfEnteredTextIsNumber(); TODO
    //DataTypesExercises.CheckIfTwoNumbersAreEvenOrOdd();
    //DataTypesExercises.ConvertIntegerToBinaryAndHexadecimal();
    //DataTypesExercises.HexadecimalMatrix();

    //FlowControlExercises.OperationOnTwoNumbersIf();
    //SFlowControlExercises.OperationOnTwoNumbersSwitch();
    //FlowControlExercises.CheckIfNumberIsPositive();
    //FlowControlExercises.GreatestNumber();
    //FlowControlExercises.MultiplyNumberByTenUsingWhile();
    //FlowControlExercises.MultiplyNumberByTenUsingDoWhile();
    //FlowControlExercises.RangeOfNumbers();
    //FlowControlExercises.Sum();
    //FlowControlExercises.NumberRepeated();
    //FlowControlExercises.AccessControl(); TODO
    //FlowControlExercises.StudentsGrade();
    // FlowControlExercises.RepetitiveStructures();
    //FlowControlExercises.CharAlphabet();
    //FlowControlExercises.ProductOfANumber();
    //FlowControlExercises.OddNumbersInDescending();
    //FlowControlExercises.GiveChange();
    // FlowControlExercises.ConditionalOperator();
    //FlowControlExercises.ConditionalOperatorNested();
}

static void ArraysExcercises()
{
    int[] testCaseId = new int[] { 100, 101, 102, 103, 104 };
    string[] testNames = new string[] {"Login", "UserForm", "Slenium", "Hover" };
    
    //getting data from array
    foreach (var getTestName in testNames)
    {
        Console.WriteLine("The test name is " + getTestName);
    }

    for(int i = 0; i<testCaseId.Length; i++)
    {
        Console.WriteLine(testCaseId[i]);
    }

    // not only for strings
    foreach (var id in testCaseId)
    {
        Console.WriteLine(id);
    }
}

static void CollectionsExercises()
{
    // non-generic collections : ArrayList, Hashtable

    Hashtable table = new Hashtable();
    table.Add("UserName", "ea");
    table.Add("Password", "ea123");
    table.Add("Button", "submit");

    Console.WriteLine("The Username is : " + table["UserName"]);

    foreach (var key in table.Keys)
    {
        Console.WriteLine("The value for " + key + " is : " + table[key]);

    }

        //types of generic <> collections: List<>, Dictionary<Tkey, Tvalue>, Stack<T>
        // generics??

        string[] user1 = new string[] { "Clau", "24", "clau@yahoo.com", "08297327873" };
        string[] user2 = new string[] { "Sam", "30", "sam@yahoo.com", "327834443" };
        string[] user3 = new string[] { "Jacob", "20", "jacob@yahoo.com", "7332322463" };

        // Dictionary<Key, values>
        Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
        dict.Add(1, user1);
        dict.Add(2, user2); 
        dict.Add(3, user3);

        foreach(var value in dict)
        {
            string[] userInfos = value.Value;

            foreach(var user in userInfos) 
            {
                Console.WriteLine(user);
            }
        }
}

static void GenericCollectionsWithCustomType()
{
    // dc la dictionary nu putem folosu custom types of generic data?
    //mai usor de manipulat
    List<Users> users = new List<Users>();
    users.Add(new Users { UserId = 1, UserName = "Clau", Age = 24, Email = "clauu@yahoo.com", Phone = 18398233});
    users.Add(new Users { UserId = 2, UserName = "Sam", Age = 30, Email = "sam@yahoo.com", Phone = 325667753354 });
    users.Add(new Users { UserId = 3, UserName = "Jacob", Age = 20, Email = "jacob@yahoo.com", Phone = 9327482784 });

    //or I can use this format
    List<Users> usersNew = new List<Users>()
    {
        new Users
        {
            UserId =  1,
            UserName= "Clau",
            Age = 24,
            Email = "clauu@yahoo.com",
            Phone = 3921732187
        },
        new Users
        {
            UserId = 2,

        }
    };

    foreach (var user in users)
    {
        Console.WriteLine(String.Format("The user {0} with Age {1} has Email {2} and Phone {3}", user.UserName, user.Age, user.Email, user.Phone));
    }

}
 static void EnumsEx()
{
    //enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list
    // distinct types?
    // can be created at the class lever or the namespace level

    //Console.WriteLine(GetBrowserName("Firefox"));// not strongly-typed code
    Console.WriteLine(BrowserClass.GetBrowserName(Browser.InternetExplorer));
}

static string GetBrowserName(string browser)
{
    if (browser == "firefox")
        return "firefox is opened";
    else if (browser == "chrome")
        return "chrome is opened";
    else
        return "IE is opened";
}

//TO DO: refactoring

//interface contains only the signature or declaration of methods/properties,
//but its actual implementation sits on the class where the interface is implemented
//since c# doesn't support multiple inheritance via classes, you can use multiple interfaces to implement and get the same behavior
//IWebDriver (from Selenium)  

static void UseInterfacesExercises()
{
    WebDriver driver = new Chrome();
    ((Chrome)driver).FindElement();
}