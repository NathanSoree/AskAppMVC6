using Common.Enumerations;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterSpeedExtension
    {
        public static List<MonsterSpeedEF> ToEF (this Dictionary<Speed, int> speedsTO, int monsterID)
        {
            var returnList = new List<MonsterSpeedEF>();
            foreach (var x in speedsTO)
            {
                returnList.Add(new MonsterSpeedEF 
                {
                    MonsterId = monsterID,
                    IdEnum = (int)x.Key, 
                    Value = x.Value
                });
            };           
            return returnList;
        }

        public static Dictionary<Speed, int> ToTO(this List<MonsterSpeedEF> speedsEF)
        {
            var returnDictionary = new Dictionary<Speed, int>();
            foreach (var x in speedsEF)
            {
                returnDictionary.Add((Speed)x.IdEnum, x.Value);
            };
            return returnDictionary;
        }
    }
}
