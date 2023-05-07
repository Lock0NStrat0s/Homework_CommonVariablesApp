
// Create a Console Application that has variables to hold a person's
// name, age, if they are alive, and their phone number.
// You do not need to capture these values from the user.

//initialize variables
string firstName = null;
string lastName = null;
int? age = null;
bool? isAlive = null;
string phoneNumber = null;

//capture or assign values
firstName = "Mohammad";
lastName = "Jabir";
age = 28;
isAlive = true;
phoneNumber = "(780)xxx-xxxx";

//display result
Console.WriteLine($"Hello {firstName} {lastName}. You are {age} years old. " +
    $"Are you alive? T/F {isAlive}. Your phone number is {phoneNumber}.");