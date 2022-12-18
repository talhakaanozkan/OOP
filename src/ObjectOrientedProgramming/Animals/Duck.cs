namespace ObjectOrientedProgramming.Animals
{
    public sealed record Duck : Animal
    {
        public Duck() : base(nameof(Duck)) { }

        public override string Move()
        {
            return "Swim";
        }

        public override string Sound()
        {
            return "Quack";
        }
    }
}
