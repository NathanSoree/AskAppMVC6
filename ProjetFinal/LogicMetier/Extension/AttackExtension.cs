using Common.Enumerations;
using Common.TransferObjects;
using LogicMetier.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Extension
{
    public static class AttackExtension
    {
        public static Attack ToDomain(this AttackTO attackTO)
        {
            return new Attack
            {
                DiceMultiplicator = attackTO.DiceMultiplicator,
                AttackDie = attackTO.AttackDie,
                Modifier = attackTO.Modifier,
                DamageType = attackTO.DamageType
            };
        }
        public static AttackTO ToTO(this Attack attack)
        {
            return new AttackTO
            {
                DiceMultiplicator = attack.DiceMultiplicator,
                AttackDie = attack.AttackDie,
                Modifier = attack.Modifier,
                DamageType = attack.DamageType
            };
        }
    }
}
