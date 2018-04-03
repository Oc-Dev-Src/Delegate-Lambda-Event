namespace Psi.Demos.Del_Lambda_Event._3_Delegate
{
    using System;

    class KeyWord_delegate
    {
        // Déclaration du délégué
        private delegate void CalculationDelegate(int x, int y);

        private static void Addition(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

        private static void Substraction(int x, int y) => Console.WriteLine($"{x} - {y} = {x - y}");

        public static void TEST_Simple_KeyWord_delegate()
        {
            Console.WriteLine("\nTEST_Simple_KeyWord_delegate");

            // Déclaration du délégué
            CalculationDelegate del_1, del_2, del_3, del_4, del_5, del_6;

            //Instantiation directe
            del_1 = Addition;

            // Créer une instance du délégué avec le mot clé new
            del_2 = new CalculationDelegate(Addition);

            // Instantiation avec méthode anonyme.
            del_3 = new CalculationDelegate(delegate (int x, int y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            });
            
            // Affectation directe d'une méthode anônyme au délégué
            del_4 = delegate (int x, int y) { Console.WriteLine($"{x} + {y} = {x + y}"); };

            #region On peut affécter des méthodes anonymes n'ayant pas le même nbr de paramètres
            del_5 = delegate 
            {
                Console.WriteLine("Méthode anônyme 1 qui ne répend pas aux paramètres du délégué.");
            };
            del_6 = new CalculationDelegate(delegate 
            {
                Console.WriteLine("Méthode anônyme 2 qui ne répend pas aux paramètres du délégué.");
            });
            #endregion

            // Appel de la méthode ' Addition ' à travers l'appel 
            // d'une instance du délégué ' CalculationDelegate '
            del_1(3, 1);
            del_2(5, 2);
            del_3(8, 4);
            del_4(13, 3);
            del_5(11, 1);
            del_6(9, 8);
        }

        public static void TEST_Multicast_KeyWord_delegate()
        {
            Console.WriteLine("\nTEST_Multicast_KeyWord_delegate");

            CalculationDelegate _del7 = Addition;

            _del7 += new CalculationDelegate(Substraction);

            // Caster avec une méthode anonyme.
            _del7 += delegate (int x, int y) { Console.WriteLine($"{x} * {y} = {x * y}"); };

            _del7 += delegate 
            {
                Console.WriteLine("Casting d'une méthode anônyme 1 ne répendendant pas aux paramètres du délégué. !");
            };

            // Appel
            _del7(5, 2);

            //Afficher le nombre de méthodes déléguées dans la liste
            Console.WriteLine($"La pile comporte {_del7.GetInvocationList().GetLength(0)} méthodes déléguées.");        
        }
    }
}