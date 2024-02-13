using System;

class PassGen
{
    static string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#%&/()=?_";
        Random random = new Random();
        char[] password = new char[length];
        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }
        return new string(password);
    }

    static void Main(string[] args)
    {
        Console.Title = "PassGen";
        Console.WriteLine("This simple program generates random passwords by your length of choice.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Created by Atmo.\n");
        Console.ResetColor();

        int length;

        if (args.Length > 0 && int.TryParse(args[0], out length))
        {
            string password = GeneratePassword(length);
            Console.Write("Your new password is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(password);
            Console.ResetColor();
        }
        else
        {
            Console.Write("Enter the length of the password: ");
            length = int.Parse(Console.ReadLine());

            string password = GeneratePassword(length);
            Console.Write("Generated password: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(password);
            Console.ResetColor();
        }

        //Exit
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
