namespace ObjectOrientedProgramming.Animals
{
    public abstract record Animal(string Name)
    {
        public bool Sleeping { get; private set; }

        public string Drink()
        {
            return "Drink";
        }

        public string Eat()
        {
            return "Eat";
        }

        public virtual string Move()
        {
            return "Move";
        }

        public abstract string Sound();

        public void Awake()
        {
            Sleeping = false;
        }

        public void Sleep()
        {
            Sleeping = true;
        }
    }
}
