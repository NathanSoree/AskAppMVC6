using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework
{
    public class ActionEF
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAttack { get; set; }
        public AttackEF Attack { get; set; }
    }
}
