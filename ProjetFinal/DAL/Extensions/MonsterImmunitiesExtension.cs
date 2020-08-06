using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterImmunitiesExtension
    {
        public static List<MonsterImmunitiesEF> ToEFImmu(this MonsterTO monsterTO, int monsterId)
        {
            var returnList = new List<MonsterImmunitiesEF>();
            foreach (var x in monsterTO.Immunities)
            {
                returnList.Add(new MonsterImmunitiesEF
                {
                    MonsterId = monsterId,
                    IdEnum = (int)x
                });
            }
            return returnList;
        }
        public static List<DamageType> ToTOImmu(this List<MonsterImmunitiesEF> immunitiesEF)
        {
            var returnList = new List<DamageType>();
            foreach (var x in immunitiesEF)
            {
                returnList.Add((DamageType)x.IdEnum);
            };
            return returnList;
        }
    }
}
