using System;
using TechTalk.SpecFlow;

namespace Gaincapital_v1
{
    [Binding]
    public class ForeignExchangeSteps
    {
        [Given(@"I have a API client")]
        public void GivenIHaveAAPIClient()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I ask about lastes foreign exchange reference rates\.")]
        public void WhenIAskAboutLastesForeignExchangeReferenceRates_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should have latest foreign exchange reference rates")]
        public void ThenIShouldHaveLatestForeignExchangeReferenceRates()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
