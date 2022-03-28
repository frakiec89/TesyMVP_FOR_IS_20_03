using System;
using ConsoleApp23.Core;

namespace ConsoleApp23.BL
{
    public class AutorizationMock : IAutorization
    {
        private string _masterPassword = "123";

        public bool AuthorizationPassword(string password)
        {
             if (password == _masterPassword) //todo прикрутить  БД
                    return true;
             else return false;
        }
    }
}
