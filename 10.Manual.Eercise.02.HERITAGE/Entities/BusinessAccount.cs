using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class BusinessAccount : Account{
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) {
            LoanLimit = loanLimit;
        }

        public void Loan(double loanAmount) {
            if (loanAmount <= LoanLimit) {
                Balance += loanAmount;
            }
        }
    }
}
