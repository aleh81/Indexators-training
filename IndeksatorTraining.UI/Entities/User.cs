namespace IndeksatorTraining.UI.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is User))
            {
                return false;
            }
            else
            {
                return Id == ((User)obj).Id;
            }
        }

        public override int GetHashCode()
        {
            return Id; 
        }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }
    }
}
