using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class AttackExtensionDAL
    {
        public static AttackEF ToEF(this AttackTO attackTO)
        {
            return new AttackEF
            {
                DiceMultiplicator = attackTO.DiceMultiplicator,
                AttackDie = attackTO.AttackDie,
                Modifier = attackTO.Modifier,
                DamageType = attackTO.DamageType
            };
        }
        public static AttackTO ToTO(this AttackEF attack)
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
