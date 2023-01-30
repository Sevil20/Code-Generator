using System;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        RandomPassword();
    }
    public static void RandomPassword()
    {
        try
        {
            int user = int.Parse(Console.ReadLine());

            Random random = new Random();
            string password = String.Empty;
            for (int i = 0; i < user; i++)
            {
                int order = random.Next(1, 5);
                char character = order switch
                {
                    1 => Convert.ToChar(random.Next(48, 58)),
                    2 => Convert.ToChar(random.Next(97, 123)),
                    3 => Convert.ToChar(random.Next(65, 91)),
                    4 => Convert.ToChar(random.Next(33, 48))

                };
                password += character;
            }
            if (user < 9)
            {
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("9dan kicik reqem daxil edin!");
            }

        }
        catch (Exception e) {
            Console.WriteLine("sehvlik var");
            Console.WriteLine(e.StackTrace);
        }
     

    }
}
