Feature: Testing api from https://exchangeratesapi.io/
@VeryFirstTest
Scenario: Get latest foreign exchange reference rates
	Given I have an API client 
	When I ask about lastes foreign exchange reference rates.
	Then I should have latest foreign exchange reference rates
