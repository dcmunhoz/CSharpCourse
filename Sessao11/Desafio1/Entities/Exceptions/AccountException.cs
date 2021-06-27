using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message) { }

    }
}
