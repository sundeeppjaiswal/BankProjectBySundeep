﻿// See https://aka.ms/new-console-template for more information
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

    //declare variable to store menu choice
    int mainMenuChoice = -1;

    do
    {
        //show main menu
        System.Console.WriteLine("\n***Main menu***");
        System.Console.WriteLine("1. Customers");
        System.Console.WriteLine("2. Accounts");
        System.Console.WriteLine("3. Funds Transfer");
        System.Console.WriteLine("4. Funds Transfer Statement");
        System.Console.WriteLine("5. Account Statement");
        System.Console.WriteLine("0. Exit");

        //accept menu choice from keyboard
        System.Console.Write("Enter choice: ");
        mainMenuChoice = int.Parse(Console.ReadLine());

        //switch-case to check menu choice
        switch (mainMenuChoice)
        {
            case 1: //TO DO: Display customers menu
                break;
            case 2: //TO DO: Display accounts menu
                break;
            case 3: //TO DO: Display funds transfer menu
                break;
            case 4: //TO DO: Display funds transfer statement menu
                break;
            case 5: //TO DO: Display account statement menu
                break;
        }
    } while (mainMenuChoice != 0);
}
else
{
    System.Console.WriteLine("Invalid username or password");
}


//about to exit
Console.WriteLine("Thank you! Visit again.");
Console.ReadKey();
