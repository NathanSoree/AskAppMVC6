using System;
using System.Collections.Generic;
using System.Text;

namespace Common.TransferObjects
{
    public class ActionTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAttack { get; set; }
        public AttackTO Attack { get; set; }
    }
}
