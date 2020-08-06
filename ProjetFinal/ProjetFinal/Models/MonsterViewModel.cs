using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFinal.Models
{
    public class MonsterViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author{ get; set; }
        public string Name { get; set; }
        public Common.Enumerations.Type Kind { get; set; }
        public Size Size { get; set; }
    }
}
