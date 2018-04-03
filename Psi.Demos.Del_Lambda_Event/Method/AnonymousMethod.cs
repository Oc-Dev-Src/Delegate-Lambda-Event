namespace Psi.Demos.Del_Lambda_Event._2_AnonymousMethod
{
    using System;

    class AnonymousMethod
    {
        public delegate void _delegate(int x, int y);

        // Méthodes anonymes
        public static _delegate Anonymous_Del = delegate (int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        };

        public static void TEST_AnonymousMethod()
        {
            Console.WriteLine("\nTEST_AnonymousMethod");
            Anonymous_Del(7,3);
        }
    }
}