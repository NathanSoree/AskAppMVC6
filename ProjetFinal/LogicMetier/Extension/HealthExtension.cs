using Common.TransferObjects;
using LogicMetier.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Extension
{
    public static class HealthExtension
    {
        public static Health ToDomain(this HealthTO healthTO)
        {
            return new Health
            {
                Multiplicator = healthTO.Multiplicator,
                HitDie = healthTO.HitDie,
                ConModifier = healthTO.ConModifier
            };
        }
        public static HealthTO ToTO(this Health health)
        {
            return new HealthTO
            {
                Multiplicator = health.Multiplicator,
                HitDie = health.HitDie,
                ConModifier = health.ConModifier
            };
        }
    }
}
