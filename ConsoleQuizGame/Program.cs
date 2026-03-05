using System;

class QuizGame
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Welcome to the C# Quiz Game!");
        Console.WriteLine("----------------------------");

        // Question 1
        Console.WriteLine("1. What does C# primarily run on?");
        Console.WriteLine("A. .NET Framework");
        Console.WriteLine("B. Java Virtual Machine");
        Console.WriteLine("C. Python Interpreter");
        Console.Write("Answer: ");
        string answer1 = Console.ReadLine().ToUpper();

        if (answer1 == "A")
        {
            score++;
        }

        // Question 2
        Console.WriteLine("\n2. Which keyword is used to define a class in C#?");
        Console.WriteLine("A. define");
        Console.WriteLine("B. class");
        Console.WriteLine("C. object");
        Console.Write("Answer: ");
        string answer2 = Console.ReadLine().ToUpper();

        if (answer2 == "B")
        {
            score++;
        }

        // Question 3
        Console.WriteLine("\n3. What symbol is used to end a statement in C#?");
        Console.WriteLine("A. :");
        Console.WriteLine("B. ;");
        Console.WriteLine("C. .");
        Console.Write("Answer: ");
        string answer3 = Console.ReadLine().ToUpper();

        if (answer3 == "B")
        {
            score++;
        }

        Console.WriteLine("\nQuiz Finished!");
        Console.WriteLine("Your score: " + score + "/3");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}