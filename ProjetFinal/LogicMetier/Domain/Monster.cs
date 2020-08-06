using Common.Enumerations;
using System.Collections.Generic;

namespace LogicMetier.Domain
{
    public class Monster
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsWide { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }
        public Size Size { get; set; }
        public Alignment Alignment { get; set; }
        public int ArmorClass { get; set; }
        public Health Health{ get; set; }
        public Dictionary<Speed,int> Speeds { get; set; }
        public Dictionary<Stat,int> Stats { get; set; }
        public List<Stat> Saving { get; set; }
        public Dictionary<Skill,Proficiency> Skills { get; set; }
        public List<DamageType> Vulnerabilities { get; set; }
        public string OtherVulnerabilities { get; set; }
        public List<DamageType> Resistances { get; set; }
        public string OtherResistences { get; set; }
        public List<DamageType> Immunities { get; set; }
        public string OtherImmunities { get; set; }
        public List<Condition> ConditionImmunities { get; set; }
        public Dictionary<Sense,int> Senses { get; set; }
        public List<string> Languages { get; set; }
        public DifficultyRating DifficultyRating { get; set; }
        public List<Traits> Traits { get; set; }
        public List<Action> Actions { get; set; }
        public int NbrLegendaryActionPerTurn { get; set; }
        public List<LegendaryAction> LegendaryActions { get; set; }
        public List<Reaction> Reactions { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsValid() 
        {
            //TODO Compléter ça
            if (string.IsNullOrWhiteSpace(Author)) return false;
            return true;
        }
    }
}