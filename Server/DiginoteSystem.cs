using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class DiginoteSystem
    {
        private static double QUOTE = 1.00;

        public double GetCurrentQuote() {
            // TODO if logged in
            return QUOTE;
        }

        public void Register(string name, string nickname, string password) { }

        public void Logout(string nickname, string password) { }

        public Boolean Login(string nickname, string password) {
            return false;
        }

    }
}
