namespace ObjectOrientedProgramming.Animals
{
    public sealed record Eagle : Animal
    {
        public Eagle() : base(nameof(Eagle)) { }

        public override string Move()
        {
            return "Fly";
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
