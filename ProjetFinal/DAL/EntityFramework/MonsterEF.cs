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
        public bool IsWide { get; set; }
        public string Name { get; set; }
        public Kind Type { get; set; }
        public Size Size { get; set; }
        public Alignment Alignment { get; set; }
        public int ArmorClass { get; set; }
        public HealthEF Health { get; set; }
        public Dictionary<Speed, int> Speeds { get; set; }
        public Dictionary<Stat, int> Stats { get; set; }
        public List<Stat> Saving { get; set; }
        public Dictionary<Skill, Proficiency> Skills { get; set; }
        public List<DamageType> Vulnerabilities { get; set; }
        public List<DamageType> Resistances { get; set; }
        public List<DamageType> Immunities { get; set; }
        public List<Condition> ConditionImmunities { get; set; }
        public Dictionary<Sense, int> Senses { get; set; }
        public List<string> Languages { get; set; }
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
