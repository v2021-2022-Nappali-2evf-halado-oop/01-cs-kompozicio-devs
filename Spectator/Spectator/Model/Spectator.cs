using System;
using System.Collections.Generic;
using System.Text;

namespace Spectator.Model
{
    class Spectator
    {
        Name name;
        CreditCard creditCard;
        BonusCard bonusCard;

        public CreditCard CreditCard { get; set; }



        public BonusCard BonusCard { get; set; }

        


        public Spectator(Name name, CreditCard creditCard, BonusCard bonusCard)
        {
            this.name = name;
            this.creditCard = creditCard;
            this.bonusCard = bonusCard;


        }


    }
}
