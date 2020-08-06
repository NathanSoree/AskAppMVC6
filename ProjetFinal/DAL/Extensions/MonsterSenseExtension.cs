using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterSenseExtension
    {
        public static List<MonsterSenseEF> ToEFSense(this MonsterTO monsterTO)
        {
            var returnList = new List<MonsterSenseEF>();
            foreach (var x in monsterTO.Senses)
            {
                returnList.Add(new MonsterSenseEF
                {
                    MonsterId = monsterTO.Id,
                    IdEnum = (int)x.Key,
                    Value = x.Value,
                });
            }
            return returnList;
        }


        public static Dictionary<Sense, int> ToTOSense(this List<MonsterSenseEF> senseEF)
        {
            var returnDictionary = new Dictionary<Sense, int>();
            foreach (var x in senseEF)
            {
                returnDictionary.Add((Sense)x.IdEnum, x.Value);
            };
            return returnDictionary;
        }
    }
}
