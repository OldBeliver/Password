using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string passwordCerification;
            string message = "Quod licet Jovi, non licet bovi";

            int trial = 3;
            int currentTrial = 3;

            Console.WriteLine("Введите новый пароль:");
            password = Console.ReadLine();            

            for (int i = 0; i < trial; i++)
            {
                Console.WriteLine("Подтвердите пароль:");
                passwordCerification = Console.ReadLine();

                if (password == passwordCerification)
                {
                    Console.WriteLine(message);
                    i = trial;
                }
                else
                {
                    currentTrial--;
                    Console.WriteLine($"Оставшиеся попытки: {currentTrial}");
                }
            }

            if (currentTrial == 0)
            {
                Console.WriteLine($"Пароль не подтвержден.");
            }
        }
    }
}
