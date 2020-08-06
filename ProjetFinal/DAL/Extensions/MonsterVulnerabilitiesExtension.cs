using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterVulnerabilitiesExtension
    {
        public static List<MonsterVulnerabilitiesEF> ToEFVuln(this MonsterTO monsterTO, int monsterId)
        {
            var returnList = new List<MonsterVulnerabilitiesEF>();
            foreach (var x in monsterTO.Vulnerabilities)
            {
                returnList.Add(new MonsterVulnerabilitiesEF
                {
                    MonsterId = monsterId,
                    IdEnum = (int)x
                });
            }
            return returnList;
        }
        public static List<DamageType> ToTOVuln(this List<MonsterVulnerabilitiesEF> vulnerabilitiesEF)
        {
            var returnList = new List<DamageType>();
            foreach (var x in vulnerabilitiesEF)
            {
                returnList.Add((DamageType)x.IdEnum);
            };
            return returnList;
        }
    }
}
