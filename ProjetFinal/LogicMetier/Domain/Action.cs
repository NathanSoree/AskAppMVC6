using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Domain
{
    public class Action
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAttack { get; set; }
        public Attack Attack { get; set; }
    }
}
