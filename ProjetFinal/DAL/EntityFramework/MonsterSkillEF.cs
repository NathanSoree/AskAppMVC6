using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EntityFramework
{
    public class MonsterSkillEF
    {
        [Key]
        public int MonsterId { get; set; }
        public MonsterEF Monster { get; set; }
        [Key]
        public int IdEnumSkill { get; set; }
        public int IdEnumProf { get; set; }
    }
}
