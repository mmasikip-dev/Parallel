using BoDi;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace StepsProject.Steps
{
    [Binding]
    public class StepsBinding
    {
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;

        public StepsBinding(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _scenarioContext = _objectContainer.Resolve<ScenarioContext>();
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            Thread.Sleep(3000);
            Console.WriteLine("THIS STEP IS DONE");
        }

        [Given(@"the first number is")]
        public void GivenTheFirstNumberIs()
        {
            Thread.Sleep(5000);
            Console.WriteLine("THIS STEP IS DONE 2");
        }
    }
}
