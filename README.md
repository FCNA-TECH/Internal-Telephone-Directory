# Internal-Telephone-Directory

This is my first technical project ive created in C# since i started learning the language in September, this was a challenge excersise from my Computing class.

I have written a programme that stores the Names, Numbers and Job Titles of a company's list of employees in C#. I have used User Defined Data-Types, File Manipulation, Functions and Error Trapping/Input Validation along with other programming methods to make this programme. This whole project was coded online using Repl, which requires all functiions to have the "static" keyword infront of them.


The objective:
Write a program to store an internal telephone directory for a company. 

Declare a structure to store the names, telephone numbers and job titles of employees. 

The program needs a menu that will allow the user to choose to create a file containing several directory records, read and display all the records in the file, search for one person's telephone number using their name or add a new employee's details to the existing file. 

The menu should have options to: 
1. Create the directory
2. Read and display the contents of the directory
3. Find a phone number using name
4. Add a new employee to the directory
5. Exit program
  
Creating the directory:
The program should allow the user to enter the details for as many as they would like. 

Read and Display the directory:
The program should display the entire contents of the file. 

Find a phone number:
The program should ask user which name is required then search the file for that name. If the name is found then corresponding telephone number and job title should be displayed. The program should display a suitable message if the name is not found. 

Add a new employee to the directory:
The program should ask the user to enter all the details of the new employee and then save those details to the end of the file. Make sure you choose the correct file mode. 

Extension:
Use a function to input and validate the names and job titles. 
Use a function to input and validate the telephone numbers. 
Add error trapping to stop the program crashing if the user tries to read the file if it doesn't exist. 
Add error trapping to stop the user accidently overwriting the file.
