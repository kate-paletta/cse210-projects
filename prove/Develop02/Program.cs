using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do? ");

        //user input variable
        int userChoice = Convert.ToInt32(Console.ReadLine());

        if (userChoice == 1) {
            Entry write = new Entry();
            write.userText();
        }

        if (userChoice == 2)
        {
            //Display the file that was saved
        }

        if (userChoice == 3)
        {
            //User loads txt file that they created into the program
        }

        if (userChoice == 4)
        {
            //User can save a txt file that they create
        }

        if (userChoice == 5)
        {
            //ends program
        }


    }
}