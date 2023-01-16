using System;

class Program
{
    static void Main(string[] args)
    {
        Random randonGenerator = new Random();
        int magicNum = randonGenerator.Next(1, 101);

        int userNum = -1;

        while (userNum != magicNum)
        {
            Console.Write("What is your guess? ");
            userNum = int.Parse(Console.ReadLine());

            if (magicNum > userNum)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < userNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}