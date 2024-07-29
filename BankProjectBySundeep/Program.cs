// See https://aka.ms/new-console-template for more information
//display title
Console.WriteLine("************** Bank Project by Sundeep *****************");
Console.WriteLine("**Login Page**");

//declare variables to store username and password;
string userName = null, password = null;

//read userName from keyboard
Console.Write("Username: ");
userName = Console.ReadLine();

//read password from keyboard only if username is entered
if (userName != "")
{
    Console.Write("Password: ");
    password = Console.ReadLine();
}

//check username and password
if (userName == "system" && password == "manager")
{
    Console.WriteLine("TO DO: Main menu here");
}

//about to exit
Console.WriteLine("Thank you! Visit again.");
Console.ReadKey();
