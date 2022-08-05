namespace BDDwithSpecflow.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Before Scenario runned.");
        }
        
        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("After Scenario runned.");
        }
    }
}