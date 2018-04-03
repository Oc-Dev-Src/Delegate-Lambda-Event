namespace Psi.Demos.Del_Lambda_Event._1_SimpleMethod
{
    using System;

    class SimpleMethod
    {
        private static void Greeting(string name)
        {
            Console.WriteLine($"Bienvenue à {name} au monde de la programmation C# !");
        }

        private static void Addition(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        private static void Substraction(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public static void TEST_SimpleMethods()
        {
            Console.WriteLine("TEST_SimpleMethods");

            Greeting("toi");
            Addition(5, 3);
            Substraction(5, 3);
        }
    }
}