using ObjectOrientedProgramming.Animals;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction(); // Abstraction example

            Encapsulation(); // Encapsulation example

            DependencyInjection(); // DependencyInjection example

            Polymorphism(); // Polymorphism example

            Console.ReadKey();
        }

        #region Abstraction

        /// <summary>
        /// Abstraction example
        /// </summary>
        private static void Abstraction()
        {
        }

        #endregion

        #region Encapsulation

        /// <summary>
        /// Animals
        /// </summary>
        private static IEnumerable<Animal> Animals => new List<Animal> {
            new Cat(),
            new Dog(),
            new Duck(),
            new Eagle(),
            new Lion(),
            new Snake()
        };

        /// <summary>
        /// Encapsulation example
        /// </summary>
        private static void Encapsulation()
        {
            Console.WriteLine(nameof(Encapsulation).ToUpper());

            foreach (var animal in Animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");

                animal.Awake();
                Console.WriteLine($"Sleeping: {animal.Sleeping}");

                animal.Sleep();
                Console.WriteLine($"Sleeping: {animal.Sleeping}");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        #endregion

        #region DependencyInjection

        /// <summary>
        /// Abstraction example
        /// </summary>
        private static void DependencyInjection()
        {
        }

        #endregion

        #region Polymorphism

        /// <summary>
        /// Abstraction example
        /// </summary>
        private static void Polymorphism()
        {
        }

        #endregion

    }
}