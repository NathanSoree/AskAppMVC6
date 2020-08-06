using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EntityFramework
{
    public class MonsterSpeedEF
    {
        [Key]
        public int MonsterId { get; set; }
        public MonsterEF Monster { get; set; }
        [Key]
        public int IdEnum { get; set; }
        public int Value { get; set; }
    }
}
