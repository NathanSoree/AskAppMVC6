using Common.Enumerations;

namespace LogicMetier.Domain
{
    public class Monster
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public Kind Kind { get; set; }
        public Size Size { get; set; }

        public bool IsValid() 
        {
            //TODO Compléter ça
            return true;
        }
    }
}