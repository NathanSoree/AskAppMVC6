using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterCondImmuExtension
    {
    
        public static List<MonsterCondImmuEF> ToEFCondImmu(this MonsterTO monsterTO, int monsterId)
        {
            var returnList = new List<MonsterCondImmuEF>();
            foreach (var x in monsterTO.Immunities)
            {
                returnList.Add(new MonsterCondImmuEF
                {
                    MonsterId = monsterId,
                    IdEnum = (int)x
                });
            }
            return returnList;
        }
        public static List<Condition> ToTOCondImmu(this List<MonsterCondImmuEF> immunitiesEF)
        {
            var returnList = new List<Condition>();
            foreach (var x in immunitiesEF)
            {
                returnList.Add((Condition)x.IdEnum);
            };
            return returnList;
        }
    
    }
}
