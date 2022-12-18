namespace ObjectOrientedProgramming.Animals
{
    public sealed record Cat : Animal
    {
        public Cat() : base(nameof(Cat)) { }

        public override string Sound()
        {
            return "Meow";
        }
    }
}
