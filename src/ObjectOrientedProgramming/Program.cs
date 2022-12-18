using ObjectOrientedProgramming.Animals;
using ObjectOrientedProgramming.Notifications;
using ObjectOrientedProgramming.Payments;
using ObjectOrientedProgramming.Repositories;

namespace ObjectOrientedProgramming
{
    internal static class Program
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
            Console.WriteLine(nameof(Abstraction).ToUpper());

            IEntityRepository repository = new EntityCosmosRepository();

            Console.WriteLine(repository.GetType().Name);

            repository = new EntityMongoRepository();

            Console.WriteLine(repository.GetType().Name);

            Console.WriteLine();
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
            Console.WriteLine(nameof(DependencyInjection).ToUpper());

            new PaymentService(new Cash()).Pay(1000);
            new EmailNotification().Notify(new EmailMessage("To", "Subject", "Body"));
            new SmsNotification().Notify(new SmsMessage("Number", "Body"));

            new PaymentService(new CreditCard()).Pay(1000);
            new SmsNotification().Notify(new SmsMessage("Number", "Body"));

            new PaymentService(new CreditCard()).Pay(2000);
            new EmailNotification().Notify(new EmailMessage("To", "Subject", "Body"));

            new PaymentService(new DebitCard()).Pay(1000);
            new SmsNotification().Notify(new SmsMessage("Number", "Body"));

            Console.WriteLine();
        }

        #endregion

        #region Polymorphism

        /// <summary>
        /// Abstraction example
        /// </summary>
        private static void Polymorphism()
        {
            Console.WriteLine(nameof(Polymorphism).ToUpper());

            foreach (var animal in Animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
                Console.WriteLine($"Move: {animal.Move()}");
                Console.WriteLine($"Sound: {animal.Sound()}");
                Console.WriteLine();
            }
        }

        #endregion

    }
}