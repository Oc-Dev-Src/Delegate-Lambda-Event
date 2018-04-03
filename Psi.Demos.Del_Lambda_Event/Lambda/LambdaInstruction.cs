namespace Psi.Demos.Del_Lambda_Event._4_LambdaInstruction
{
    using System;

    class LambdaInstruction
    {
        // Déclaration avec un seul paramètre
        private delegate void GreetingDelegate(string name);
        
        // Déclaration sans paramètres
        private delegate void GreetingDelegate_1();

        public static void TEST_LambdaInstructions()
        {
            Console.WriteLine("\nTEST_LambdaInstructions");

            #region Délégué avec un seul paramètre
            GreetingDelegate del_1;

            // Méthode anônyme
            del_1 = delegate (string name)
            {
                Console.WriteLine($"Bienvenue à {name} au monde de la programmation C# !");
            };

            // Instruction Lambda avec spécification du paramètre
            del_1 += (string name) =>
            {
                Console.WriteLine($"Bienvenue à {name} au monde de la programmation C# !");
            };

            // Instruction Lambda sans spécifier le type du paramètre "Utilisation de l'inférence de type"
            del_1 += (name) =>
            {
                Console.WriteLine($"Bienvenue à {name} au monde de la programmation C# !");
            };

            // Suppression des parenthèses en cas de signature avec un seul paramètre
            del_1 += name =>
            {
                Console.WriteLine($"Bienvenue à {name} au monde de la programmation C# !");
            };

            del_1("Eric");
            #endregion

            #region Délégué sans paramètre
            GreetingDelegate_1 del_2;
            del_2 = () => { Console.WriteLine($"Bienvenue au monde de la programmation C# !"); };
            del_2(); 
            #endregion
        }
    }
}