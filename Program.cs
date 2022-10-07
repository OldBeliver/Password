using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string passwordVerification;
            string message = "Quod licet Jovi, non licet bovi";
            
            int trial = 3;
                        
            Console.WriteLine("Введите новый пароль:");
            password = Console.ReadLine();            

            for (int i = trial; i > 0; i--)
            {
                Console.WriteLine("Подтвердите пароль:");
                Console.WriteLine($"Осталось {i} попытки");
                passwordVerification = Console.ReadLine();

                if(password == passwordVerification)
                {
                    Console.WriteLine(message);
                    i = 0;
                }
                else
                {
                    Console.WriteLine($"Пароль не подтвержден.");
                }                
            }
        }
    }
}
