using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework
{
    public class MonsterEF
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string LairAction { get; set; }
        public string RegEffects { get; set; }
        public bool IsWide { get; set; }
        public string Name { get; set; }
        public Common.Enumerations.Type Type { get; set; }
        public Size Size { get; set; }
        public Alignment Alignment { get; set; }
        public int ArmorClass { get; set; }
        public HealthEF Health { get; set; }
        public virtual List<MonsterSpeedEF> Speeds { get; set; }
        public virtual List<MonsterStatsEF> Stats { get; set; }
        public virtual List<MonsterSkillEF> Skills { get; set; }
        public virtual List<MonsterVulnerabilitiesEF> Vulnerabilities { get; set; }
        public string OtherVulnerabilities { get; set; }
        public virtual List<MonsterResistanceEF> Resistances { get; set; }
        public string OtherResistences { get; set; }
        public virtual List<MonsterImmunitiesEF> Immunities { get; set; }
        public string OtherImmunities { get; set; }
        public virtual List<MonsterCondImmuEF> ConditionImmunities { get; set; }
        public virtual List<MonsterSenseEF> Senses { get; set; }
        public virtual List<MonsterLanguageEF> Languages { get; set; }
        public DifficultyRating DifficultyRating { get; set; }
        public List<TraitsEF> Traits { get; set; }
        public List<ActionEF> Actions { get; set; }
        public int NbrLegendaryActionPerTurn { get; set; }
        public List<LegendaryActionEF> LegendaryActions { get; set; }
        public List<ReactionEF> Reactions { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsValid()
        {
            var idIsValid = Id > 0;
            if (!idIsValid) throw new Exception("Id not valid");
            //TODO Compléter ça
            return true;
        }
    }
}
