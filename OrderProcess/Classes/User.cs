using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcess.Classes
{
    internal class User
    {
        private string CardNumber { get; set; }
        private string FirstName { get; set; }
        private string SurName { get; set; }
        private string expDate { get; set; }
        private string cvcCode { get; set; }
        private int amount { get; set; }
        public User(string CardNumber, string FirstName, string SurName, string expDate, string cvcCode, int amount) 
        {
            this.CardNumber = CardNumber;
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.expDate = expDate;
            this.cvcCode = cvcCode;
            this.amount = amount;
        }

        public string getCardNumber() 
        {
            return this.CardNumber;
        }

        public string getFullName() 
        {
            return this.FirstName + " " + this.SurName;
        }

        public string getExpDate() 
        {
            return this.expDate;
        }

        public string getCvcCode() 
        {
            return this.cvcCode;
        }

        public override string ToString()
        {
            return $"{CardNumber};{FirstName+" "+SurName};{expDate};{cvcCode};{amount}";
        }
    }
}
