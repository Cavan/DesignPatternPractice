using PatternImplementation.Patterns;
using PatternImplementation.Patterns.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAbstractFactory();
            //RunVehicleBuilder();
            RunDocumentFactory();

            // Wait for input
            Console.ReadKey();
        }

        private static void RunAbstractFactory()
        {
            // Create and run the Battlefield world
            GunFactory playerWeapons = new GunCachePlayer();
            TheBattlefield world = new TheBattlefield(playerWeapons);
            world.RunBattle();
        }

        private static void RunVehicleBuilder()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }

        private static void RunDocumentFactory()
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}
