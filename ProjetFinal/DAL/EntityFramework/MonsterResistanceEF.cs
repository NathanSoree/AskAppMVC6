﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.EntityFramework
{
    public class MonsterResistanceEF
    {
        [Key]
        public int MonsterId { get; set; }
        public MonsterEF Monster { get; set; }
        public int IdEnum { get; set; }

    }
}
