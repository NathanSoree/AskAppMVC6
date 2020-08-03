using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Domain
{
    public class Attack
    {
        public int DiceMultiplicator { get; set; }
        public Die AttackDie { get; set; }
        public int Modifier { get; set; }
        public DamageType DamageType { get; set; }
    }
}
