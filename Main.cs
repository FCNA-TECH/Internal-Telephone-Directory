using System;
using System.IO;

class Program 
{
  public static void Main (string[] args) 
  {

    int getmeoutofhere = 0;  //this decides whther the programs quits or not
    while (true){
      string option2 = DisplayMenu();
      while(option2 != "1" && option2 != "2" && option2 != "3" && option2 != "4" && option2 != "5"){
        Console.WriteLine("");
        Console.WriteLine("You must enter either 1 - 5  ");
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
          SearchFile();
          break;
        case "4":
          AppendFile();
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


  public static void CreateFile()
  {
    FileStream stream = File.Open("MyDatabase.txt", FileMode.Create);
    StreamWriter writer = new StreamWriter(stream);
    Console.WriteLine(" ");
    Console.WriteLine("How many people? ");
    int HowMany = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine(" ");
    for (int Count = 1; Count <= HowMany; Count++)
    {
      Contact employee = new Contact();
      
      Console.WriteLine("Enter Name: ");
      string Name1 = Console.ReadLine();
      employee.Name = Name1;

      Console.WriteLine("Enter Phone Number: ");
      string Number1 = Console.ReadLine();
      employee.Number = Number1;

      Console.WriteLine("Enter Job Title: ");
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
      Console.WriteLine("{0}. Employee Name: {1}",i, employee.Name);
      Console.WriteLine("{0}. Employee Phone Number: {1}",i, employee.Number);
      Console.WriteLine("{0}. Employee Job Title: {1}",i, employee.JobTitle);
      Console.WriteLine(" ");
      i++;
    }
    reader.Close();
  }
  
  public static void SearchFile()
  {
    FileStream stream = File.Open("MyDatabase.txt", FileMode.Open);
    StreamReader reader = new StreamReader(stream);
    int getmeoutofhere2 = 0;   //so i can choose whether to print if name was found of not
    Contact employee = new Contact();
    Console.WriteLine(" ");
    Console.WriteLine("Enter the name you want to search:  ");
    string searchcriteria = Console.ReadLine();
    while(!reader.EndOfStream){
      employee.Name = reader.ReadLine();
      if (employee.Name == searchcriteria){
        employee.Number = reader.ReadLine();
        employee.JobTitle = reader.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Employee Found! ");
        Console.WriteLine(" ");
        Console.WriteLine("Employee Name: {0}",employee.Name);
        Console.WriteLine("Employee Phone Number: {0}",employee.Number);
        Console.WriteLine("Employee Job Title: {0}",employee.JobTitle);
        Console.WriteLine(" ");
        getmeoutofhere2 = 1;
        break;
      }
    }
    if (getmeoutofhere2 == 0){
      Console.WriteLine(" ");
      Console.WriteLine("ERROR 404: Name Not Found ");
    }
    reader.Close();
  }
    
  public static void AppendFile()
  {
    FileStream stream = File.Open("MyDatabase.txt", FileMode.Append);
    StreamWriter writer = new StreamWriter(stream);
    Console.WriteLine(" ");
    Console.WriteLine("You are now adding an extra employee onto the directory...");
    Console.WriteLine(" ");
    Contact employee = new Contact();

    Console.WriteLine("Enter Name: ");
    string Name1 = Console.ReadLine();
    employee.Name = Name1;

    Console.WriteLine("Enter Phone Number: ");
    string Number1 = Console.ReadLine();
    employee.Number = Number1;

    Console.WriteLine("Enter Job Title: ");
    string JobTitle1 = Console.ReadLine();
    employee.JobTitle = JobTitle1;

    writer.WriteLine(employee.Name);
    writer.WriteLine(employee.Number);
    writer.WriteLine(employee.JobTitle);
    Console.WriteLine("");
    Console.WriteLine("Employee Saved! ");
    Console.WriteLine("");
  
    writer.Close();
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
    Console.Write("Enter either 1 - 5:  ");
    string option1 = Console.ReadLine().ToLower();
    return option1;
    
  }
  struct Contact{
    public string Name;
    public string Number;
    public string JobTitle;
  }
}
