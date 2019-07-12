using System;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ; )
            {
                string name = Greetings();

                Age();
                Settings();
            }

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }


        ///<summary>
        /// Program settings - font color etc
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        ///<summary>
        /// check the user's age and tell him what he can buy
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);


            Console.WriteLine("Masz " + age + " lat(a).");

            if (age > 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jesteś pełnoletni. Możesz kupić alkohol.");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Wprowadziłeś niewłaściwy wiek :( ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Możemy Ci zaproponować mleko.");
            }
        }

        ///<summary>
        /// program says hello to the user
        /// </summary>
        private static string Greetings()
        {
            Console.Write("Podaj imię: ");

            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);

            return name;
        }
    }
}
