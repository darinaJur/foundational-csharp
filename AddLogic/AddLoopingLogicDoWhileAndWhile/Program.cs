/*
Add logic to C# console applications (Get started with C#, Part 3) 
Add looping logic to your code using the do-while and while statements in C# 
*/

using System;
using System.Text.RegularExpressions;

/*
Code project 1 - write code that validate integer input

Expected output:
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/

Console.WriteLine("Enter an integer value between 5 and 10");

string? readResult;
int entryNumber = 0;
bool validEntry = false;

do
{
    readResult = Console.ReadLine();
    validEntry = int.TryParse(readResult, out entryNumber);

    if (validEntry == true)
    {
        if (entryNumber < 5 || entryNumber > 10)
            validEntry = false;
            Console.WriteLine($"You entered {entryNumber}. Please enter a number between 5 and 10.");
    }
    else
        Console.WriteLine("Sorry, you intered invalid number, please try again");

} while (validEntry == false);

Console.WriteLine("Your value is accepted!");


/*
Code project 2 - write code that validates string input

Expected Output:
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/

Console.WriteLine("Enter your role name (Administrator, Manager, or User).");

string [] validRoles = new string[3] { "Administrator", "Manager", "User"};
string? readResult;
bool validEntry = false;

do {
    readResult = Console.ReadLine();

    foreach (string role in validRoles)
    {
        if (role.Equals(readResult))
        {
            validEntry = true;
            break;
        }
    }

    if(!validEntry)
        Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");

} while (validEntry == false);

Console.WriteLine($"Your input value {readResult} has been accepted.");

/*
Code project 3 - Write code that processes the contents of a string array

Expected Output:
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/

string[] myStrings = new string[2] { "I like peanuts. I like roast chicken. I like salad", "I like all three of the menu choices" };
string myString = "";

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    string[] sentences = Regex.Split(myString, @"\.\s*");

    foreach(string sentence in sentences)
    {
        if (!string.IsNullOrWhiteSpace(sentence))
            Console.WriteLine(sentence.Trim());
    }
}
