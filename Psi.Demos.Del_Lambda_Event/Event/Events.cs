namespace Psi.Demos.Del_Lambda_Event._6_Event
{
    /// <summary>
    /// Un événement est un type spécial de délégué multicast
    /// </summary>
    
    using System;

    class Events
    {
        // Déclaration du délégué
        private delegate void AnEventHandler(string s);

        // Déclaration de d'un événement du type le délégué 'AnEventHandler'
        private static event AnEventHandler AnEvent;

        private static void Greeting(string name)
        {
            Console.WriteLine($"Bienvenue à {name} au monde de la programmation C# !");
        }

        public static void TEST_Events()
        {
            Console.WriteLine("\nTEST_Events");
            // Abonner la méthode ' Bienvenue ' à l'événement ' AnEvent ' directement
            AnEvent = Greeting;

            // Abonner la méthode ' Fantastique ' à l'événement ' AnEvent ' 
            // à travers le délégué ' AnEventHandler '
            AnEvent += new AnEventHandler(Greeting);

            // Abonner une méthode anonyme à l'événement ' AnEvent ' 
            // à travers le délégué ' AnEventHandler '
            AnEvent += new AnEventHandler(delegate 
            {
                Console.WriteLine("Abonner une méthode anonyme à évènement !");
            });

            // Abonner une méthode anonyme à l'événement ' AnEvent ' directement
            AnEvent += delegate (string x) 
            {
                Console.WriteLine("Bienvenue à travers un délégué !");
            };

            // Déclanchement de l'événement: l'objet qui déclenche l'événement est appelé éditeur
            AnEvent("Alphonse");
        }
    }
}