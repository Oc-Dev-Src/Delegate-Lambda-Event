namespace Psi.Demos.Del_Lambda_Event._5_LambdaExpression
{
    /// <summary>
    /// Une expression lambda est une fonction anonyme 
    /// que vous pouvez utiliser pour créer 
    /// des types délégués ou des types d' arborescence d'expression. 
    /// 
    /// En utilisant des expressions lambda, vous pouvez 
    /// écrire des fonctions locales qui peuvent être passées comme des arguments 
    /// ou retournées comme la valeur d'appels de fonction.
    /// 
    /// Les expressions lambda sont particulièrement utiles pour écrire des expressions de requête LINQ.
    /// </summary>

    using System;

    class LambdaExpression
    {
        private static int Square(int x)
        {
            return x * x;
        }
        private static int SquareLambda(int x) => x * x;

        public static void TEST_LambdaExpressions()
        {
            Console.WriteLine("\nTEST_LambdaExpressions");

            Console.WriteLine(Square(2));
            Console.WriteLine(SquareLambda(2));
        }
    }
}