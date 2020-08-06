using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Domain
{
    public class Health
    {
        /*public Health (int multiplicator, Die hitDie, int conModifier = 0)
        {
            Multiplicator = multiplicator;
            HitDie = hitDie;
            ConModifier = conModifier;
            Average = (int)(multiplicator * (conModifier + ((int)hitDie / 2) + 0.5));

            IsValid();
        }*/

        public int Multiplicator { get; set; }
        public Die HitDie { get; set; } // hey macarena
        public int ConModifier { get; set; }
        public int Average { get; set; }

        public bool IsValid()
        {
            var invalidMultiplier = (Multiplicator <= 0);
            if (invalidMultiplier) throw new Exception("Multiplicator not valid");

            var invalidHealth = ((Multiplicator * (int)((int)HitDie / 2 + 0.5)) < (Multiplicator * ConModifier * -1)) && (ConModifier < 0);
            if (invalidHealth) throw new Exception("Negative modifier too big");

            return true;
        }
    }
}
