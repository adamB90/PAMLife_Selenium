using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps
{
    [Binding]
    public class LoginPageSteps
    {
        [When(@"the Login page loads")]
        public void WhenTheLoginPageLoads()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the login button should display on the page")]
        public void ThenTheLoginButtonShouldDisplayOnThePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
