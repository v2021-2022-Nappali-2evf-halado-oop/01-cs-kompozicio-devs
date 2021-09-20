using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;
using Spectator.Model;
namespace Spectator.Model
{
    class BonusCard
    {
        private float avaibleBalance;
        private string cardNumber;
        private Status status;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="avaibleBalance"></param>
        /// <param name="cardNumber"></param>
        /// <param name="status"></param>
        public BonusCard(string cardNumber, Status status, float avaliableBalance)
        {
            this.AvaibleBalance = avaliableBalance;
            this.CardNumber = cardNumber;
            this.Status = status;

        }

        public float AvaibleBalance { get => avaibleBalance; set => avaibleBalance = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        internal Status Status { get => status; set => status = value; }


        public bool Useablebalance
        {
            get
            {
                if (avaibleBalance > 0 && status == Status.Active)
                {
                    return true;
                }
                return false;
            }

        }

        public override string ToString()
        {
            string result = "néző adatai : \n";
            result += "\n" + cardNumber + "\n" + avaibleBalance + "\n" + status;
            return result;
        }




    }

}
