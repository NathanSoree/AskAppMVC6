using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterResistanceExtension
    {
        public static List<MonsterResistanceEF> ToEFResist(this MonsterTO monsterTO, int monsterId)
        {
            var returnList = new List<MonsterResistanceEF>();
            foreach (var x in monsterTO.Resistances)
            {
                returnList.Add(new MonsterResistanceEF
                {
                    MonsterId = monsterId,
                    IdEnum = (int)x
                });
            }
            return returnList;
        }
        public static List<DamageType> ToTOResist(this List<MonsterResistanceEF> resistanceEF)
        {
            var returnList = new List<DamageType>();
            foreach (var x in resistanceEF)
            {
                returnList.Add((DamageType)x.IdEnum);
            };
            return returnList;
        }
    }
}
