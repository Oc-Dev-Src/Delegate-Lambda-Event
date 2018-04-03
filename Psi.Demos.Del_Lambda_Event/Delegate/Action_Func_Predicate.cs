namespace Psi.Demos.Del_Lambda_Event._3_Delegate
{
    using System;

    /// <Summary>
    /// Les délégués clée en main
    /// </Summary>
    
    public class Action_Func_Predicate
    {
        private static void Greeting(string name)
        {
            Console.WriteLine($"Bienvenue à {name} au monde de la programmation C# !");
        }

        public static void TEST_Method_With_Action()
        {
            Console.WriteLine("\nTEST_Method_With_Action");

            // Action: Le délégué sans types de retour
            Action Action_Without_Param = new Action(delegate 
            {
                Console.WriteLine("Bienvenue au monde de la programmation C# !");
            });
            Action_Without_Param();

            Action<string> Action_1 = Greeting;
            Action_1("Salamé");

            Action<string> Action_2 = new Action<string>(Greeting);
            Action_2("Alice");

            Action<string> Action_3 = x => { Console.WriteLine($"Bienvenue à {x} au monde de la programmation C# !"); };
            Action_3("Alice");
            // Ou encore inline
            //((Action<string>)(x => { Console.WriteLine("Dans mon Action! " + x); }))("Alice");

            Action<int, int> Action_4 = (int x, int y) =>
            {
                Console.WriteLine($"{x} - {y} = {x - y}");
            };
            Action_4(5, 4);
        }

        public static void TEST_Method_With_Func()
        {
            Console.WriteLine("\nTEST_Method_With_Func");

            // Func: Le délégué avec type de retour auquel a été affectée une expression Lambda
            Func<double, double> Func_1 = y => y * 2;
            Console.WriteLine("Le double de 4 est {0} ", Func_1(4));


            Func<double, double, double> Func_2 = (y, z) => y + z;
            Console.WriteLine("La somme de 4 et 6 est {0} ", Func_2(4, 6));
        }

        public static void TEST_Method_With_Predicate()
        {
            Console.WriteLine("\nTEST_Method_With_Predicate");

            // Predicate: délégué qui retourne une valeur booléenne
            Predicate<string> Predicate_1 = a => a.Length != 5;
            Console.WriteLine(Predicate_1("Alice"));

            Predicate<int> Predicate_2 = new Predicate<int>(i =>
            {
                return i + 12 == 37;
            });

            if (Predicate_2(25))
                Console.WriteLine("True");
        }
    }
}