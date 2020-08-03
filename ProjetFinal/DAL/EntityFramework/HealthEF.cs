using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework
{
    public class HealthEF
    {
        public int Multiplicator { get; set; }
        public Die HitDie { get; set; } // hey macarena
        public int ConModifier { get; set; }
    }
}
