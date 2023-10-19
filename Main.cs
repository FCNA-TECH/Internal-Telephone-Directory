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
    for (int Count = 1; Count <= HowMany; Count++)
    {
      Console.WriteLine("Enter Name: ");
      string Name1 = Console.ReadLine();

      Console.WriteLine("Enter Number: ");
      string Number1 = Console.ReadLine();

      Console.WriteLine("Enter Name: ");
      string JobTitle1 = Console.ReadLine();
    }
  }
  public static void DisplayFile()
  {

  }
  public static void SearchFile()
  {

  }
  public static void AppendFile()
  {

  }
  public static string DisplayMenu()
  {
    Console.WriteLine("=========MENU=========");
    Console.WriteLine("1. Create Directory: ");
    Console.WriteLine("2. Display Directory: ");
    Console.WriteLine("3. Find # using name: "); //find the number using name was shortened to # for aesthetics
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
