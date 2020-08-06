using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Domain
{
    public class Attack
    {
        /*public Attack(int modifier, int diceMultiplicator, Die attackDie, DamageType damageType)
        {
            Modifier = modifier;
            DiceMultiplicator = diceMultiplicator;
            AttackDie = attackDie;
            DamageType = damageType;

            IsValid();
        }*/

        public int DiceMultiplicator { get; set; }
        public Die AttackDie { get; set; }
        public int Modifier { get; set; }
        public DamageType DamageType { get; set; }

        public bool IsValid()
        {
            var InvalidDamage = (!(0 < DiceMultiplicator)) 
                || !(Die.d4 <= AttackDie) 
                || !((DamageType.Acid <= DamageType) && Enum.IsDefined(typeof(DamageType), DamageType));

            if (InvalidDamage) throw new Exception("Damage not valid;");

            return true;
        }
    }
}
