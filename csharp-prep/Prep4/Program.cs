using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> userNumberList = new List<int>();
        int userNumber;

        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");

        // Create a loop to collect numbers from user
        do
        {
        Console.Write ("Enter number: ");
        string userInput = Console.ReadLine();

        // Convert user input to number
        userNumber = int.Parse(userInput);

        // Check if number is 0
        if (userNumber == 0)
        {
            Console.WriteLine("Here is your Highlights");
        }
        else
        {
        // Add numbers to list
        userNumberList.Add(userNumber);
        }
        // Loop should continue until user enters 0
        }while (userNumber != 0);

        // Sum numbers in list
        foreach (int number in userNumberList)
        {
        // write code to add numbers together
        }

        // Count the number of items in the list
        int listLength = userNumberList.Count;

        // Calculate average of numbers in list

        // Find largest number in list
    }
}