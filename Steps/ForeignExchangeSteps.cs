using System;
using TechTalk.SpecFlow;

namespace Gaincapital_v1
{
    [Binding]
    public class ForeignExchangeSteps
    {
        static LastesDto lastest;

        [Given(@"I have an API client")]
        public void GivenIHaveAnAPIClient()
        {
            Console.Write("Hello world, welcome to step");
            Console.Write(Environment.NewLine); 
        }

        [When(@"I ask about lastes foreign exchange reference rates\.")]
        public async void WhenIAskAboutLastesForeignExchangeReferenceRates_()
        {
             lastest = await ExchangeratesapiClient.GetLastesForeignExchange();
        }


        [Then(@"I should have latest foreign exchange reference rates")]
        public void ThenIShouldHaveLatestForeignExchangeReferenceRates()
        {
            Assert.IsNotNull(lastest);
        }

    }
}
