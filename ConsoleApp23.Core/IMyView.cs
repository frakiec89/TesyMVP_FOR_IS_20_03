using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Core
{
    public interface IMyView
    {
        void Start();
        string Password { get; }
        event EventHandler <EventArgs> EnterPassword;
        void Print(string message);


    }
}
