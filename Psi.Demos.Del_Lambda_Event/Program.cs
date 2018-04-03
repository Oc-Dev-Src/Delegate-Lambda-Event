namespace Psi.Demos.Del_Lambda_Event
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            _1_SimpleMethod.SimpleMethod.TEST_SimpleMethods();

            _2_AnonymousMethod.AnonymousMethod.TEST_AnonymousMethod();

            _3_Delegate.KeyWord_delegate.TEST_Simple_KeyWord_delegate();
            _3_Delegate.KeyWord_delegate.TEST_Multicast_KeyWord_delegate();
            _3_Delegate.Action_Func_Predicate.TEST_Method_With_Action();
            _3_Delegate.Action_Func_Predicate.TEST_Method_With_Func();
            _3_Delegate.Action_Func_Predicate.TEST_Method_With_Predicate();

            _4_LambdaInstruction.LambdaInstruction.TEST_LambdaInstructions();
            _5_LambdaExpression.LambdaExpression.TEST_LambdaExpressions();
            _6_Event.Events.TEST_Events();

            Console.ReadKey();
        }
    }
}