using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IBank
    {
        bool Deposit(double amount);
        bool withdraw(double amount);
        string DisplayDetails();

    }
}
