using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EntityFramework
{
    public class HealthEF
    {
        [Key]
        public int Id { get; set; }
        public int Multiplicator { get; set; }
        public Die HitDie { get; set; } // hey macarena
        public int ConModifier { get; set; }
    }
}
