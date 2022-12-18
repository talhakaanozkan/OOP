namespace ObjectOrientedProgramming.Animals
{
    public sealed record Snake : Animal
    {
        public Snake() : base(nameof(Snake)) { }

        public override string Sound()
        {
            return "Hiss";
        }
    }
}
