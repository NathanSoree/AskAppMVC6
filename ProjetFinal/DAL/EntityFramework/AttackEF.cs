using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EntityFramework
{
    public class AttackEF
    {
        [Key]
        public int Id { get; set; }
        public int DiceMultiplicator { get; set; }
        public Die AttackDie { get; set; }
        public int Modifier { get; set; }
        public DamageType DamageType { get; set; }
    }
}
