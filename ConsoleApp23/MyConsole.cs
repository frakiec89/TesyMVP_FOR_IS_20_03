using System;
using ConsoleApp23.Core;

namespace ConsoleApp23
{
    internal class MyConsole : IMyView
    {
        public event EventHandler<EventArgs> EnterPassword; // событие
        private string _password;
        public string Password { get { return _password; } }
    
        public void Start()
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Введите пароль");
            _password = Console.ReadLine();

            try
            {
                if (EnterPassword != null)
                    EnterPassword(Password, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Print(ex.Message);
            }
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}