namespace FootBall.API.Entity
{
    public class Player : BaseEntity
    {
        public int NumberOnTshirt { get; set; }
        public int ScoredGoals { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
    }
}
