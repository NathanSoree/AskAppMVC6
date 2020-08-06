using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class HealthExtensionDAL
    {
        public static HealthEF ToEF(this HealthTO healthTO)
        {
            return new HealthEF
            {
                Multiplicator = healthTO.Multiplicator,
                HitDie = healthTO.HitDie,
                ConModifier = healthTO.ConModifier
            };
        }
        public static HealthTO ToTO(this HealthEF health)
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
