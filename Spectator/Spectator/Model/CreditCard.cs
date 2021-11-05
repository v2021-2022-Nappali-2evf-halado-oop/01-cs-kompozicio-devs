using System;
using System.Collections.Generic;
using System.Text;

namespace Spectator.Model
{

    class CreditCard
    {
        private DateTime expireDate;
        private string cardNumber;

        public DateTime ExpireDate { get => expireDate; set => expireDate = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }

        public bool Expired
        {
            get
            {
                /// checking for expiration date 

                if (expireDate < DateTime.Now)
                {
                    return true;
                }
                else return false;
            }
        }
        public override string ToString()
        {
            string result = "Hitelkártya : " + cardNumber;
            result += "\nLejarati datum " + expireDate;
            if (Expired)
            {
                result += "Kartya lejart";

            }
            else
            {
                result += "A kártya aktív";

            }
            return result;
        }






    }
}
