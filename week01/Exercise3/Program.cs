using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Removed the first definition of magicNumber

        Console.Write("what is your guess? ");
    int guess = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    int magicNumber = random.Next(1, 101);
    
        while (guess != magicNumber)
        {
            Console.Write("what is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("higher.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("lower.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
                break;
            }
        }
    }
}
       