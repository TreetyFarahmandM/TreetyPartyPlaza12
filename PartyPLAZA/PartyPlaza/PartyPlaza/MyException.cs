using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class MyException : Exception
    {
        private String message;
        public MyException(string message)
        {
            this.message = message;
        }
        public String toString()
        {
            return String.Format("Error: {0}", message);
        }
    }
}
