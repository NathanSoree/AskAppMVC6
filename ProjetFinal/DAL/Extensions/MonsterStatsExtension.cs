using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterStatsExtension
    {
        public static List<MonsterStatsEF> ToEFStat(this MonsterTO monsterTO)
        {
            var returnList = new List<MonsterStatsEF>();
            foreach (var x in monsterTO.Stats)
            {
                returnList.Add(new MonsterStatsEF
                {
                    MonsterId = monsterTO.Id,
                    IdEnum = (int)x.Key,
                    Value = x.Value,
                    Saving = monsterTO.Saving.Any(sav => sav == x.Key)
                });
            }
            return returnList;
        }


        public static Dictionary<Stat, int> ToTO(this List<MonsterStatsEF> statsEF)
        {
            var returnDictionary = new Dictionary<Stat, int>();
            foreach (var x in statsEF)
            {
                returnDictionary.Add((Stat)x.IdEnum, x.Value);
            };
            return returnDictionary;
        }
        public static List<Stat> ToSavingTO(this List<MonsterStatsEF> statsEF)
        {
            var returnList = new List<Stat>();
            foreach (var x in statsEF)
            {
                if (x.Saving)
                returnList.Add((Stat)x.IdEnum);
            };
            return returnList;
        }
    }
}
