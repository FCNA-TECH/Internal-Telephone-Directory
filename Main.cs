using System;
using System.IO;

class Program 
{
  public static void Main (string[] args) 
  {
    // the start of your program should be here
    int getmeoutofhere = 0;
    while (true){
      string option2 = DisplayMenu();
      while(option2 != "1" && option2 != "2"){
        Console.WriteLine("");
        Console.WriteLine("you must enter either 1 - 5  ");
        Console.Write("");
        option2 = DisplayMenu();
      }
      switch (option2){
        case "1":
          CreateFile();
          break;
        case "2":
          DisplayFile();
          break;
        case "3":
          break;
        case "4":
          break;
        case "5":
          getmeoutofhere = 1;
          break;
      }
      if(getmeoutofhere == 1){
        break;
      }
    }
  }

  // here is an example of a function you might need
  public static void CreateFile()
  {
    FileStream stream = File.Open("MyDatabase.txt", FileMode.Create);
    StreamWriter writer = new StreamWriter(stream);
    Console.WriteLine("How many people? ");
    int HowMany = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine(" ");
    for (int Count = 1; Count <= HowMany; Count++)
    {
      Contact employee = new Contact();
      
      Console.WriteLine("Enter Name: ");
      string Name1 = Console.ReadLine();
      employee.Name = Name1;

      Console.WriteLine("Enter Number: ");
      string Number1 = Console.ReadLine();
      employee.Number = Number1;

      Console.WriteLine("Enter JobTitle: ");
      string JobTitle1 = Console.ReadLine();
      employee.JobTitle = JobTitle1;

      writer.WriteLine(employee.Name);
      writer.WriteLine(employee.Number);
      writer.WriteLine(employee.JobTitle);
      Console.WriteLine("");
      Console.WriteLine("Employee Saved! ");
      Console.WriteLine("");
    }
    writer.Close();
  }
  
  public static void DisplayFile()
  {
    FileStream stream = File.Open("MyDatabase.txt", FileMode.Open);
    StreamReader reader = new StreamReader(stream);
    Contact employee = new Contact();
    int i = 1;
    while(!reader.EndOfStream){
      employee.Name = reader.ReadLine();
      employee.Number = reader.ReadLine();
      employee.JobTitle = reader.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine("{0}. Emplyee Name: {1}",i, employee.Name);
      Console.WriteLine("{0}. Emplyee Number: {1}",i, employee.Number);
      Console.WriteLine("{0}. Emplyee JobTitle: {1}",i, employee.JobTitle);
      Console.WriteLine(" ");
      i++;
    }
    reader.Close();
  }
  public static void SearchFile()
  {

  }
  public static void AppendFile()
  {
    FileStream stream = File.Open("MyDatabase.txt", FileMode.Append);
    StreamWriter writer = new StreamWriter(stream);
  }
  public static string DisplayMenu()
  {
    Console.WriteLine(" ");
    Console.WriteLine("=========MENU=========");
    Console.WriteLine("1. Create Directory: ");
    Console.WriteLine("2. Display Directory: ");
    Console.WriteLine("3. Find # using name: ");
    Console.WriteLine("4. Append Directory: ");
    Console.WriteLine("5. Exit Program: ");
    Console.Write("enter either 1 - 5:  ");
    string option1 = Console.ReadLine().ToLower();
    return option1;
    
  }
  struct Contact{
    public string Name;
    public string Number;
    public string JobTitle;
  }
}
