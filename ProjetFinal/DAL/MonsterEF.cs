using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class MonsterEF
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public Kind Kind { get; set; }
        public Size Size { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsValid()
        {
            var idIsValid = Id > 0;
            if (!idIsValid) throw new Exception("Id not valid");
            //TODO Compléter ça
            return true;
        }
    }
}
