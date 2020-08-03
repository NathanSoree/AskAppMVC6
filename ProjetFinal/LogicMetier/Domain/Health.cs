using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Domain
{
    public class Health
    {
        public int Multiplicator { get; set; }
        public Die HitDie { get; set; } // hey macarena
        public int ConModifier { get; set; }
    }
}
