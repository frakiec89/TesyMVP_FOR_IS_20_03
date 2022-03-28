using ConsoleApp23.BL;
using ConsoleApp23.MyPresenter;
using System;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyConsole myConsole = new MyConsole(); // представление 
                AutorizationMock  autorizationMock = new AutorizationMock();
                MyAutPresenter myAutPresenter = new MyAutPresenter(autorizationMock, myConsole);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
