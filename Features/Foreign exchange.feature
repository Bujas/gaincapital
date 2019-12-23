Feature: Foreign exchange
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Get latest foreign exchange reference rates
	Given I have a API client 
	When I ask about lastes foreign exchange reference rates.
	Then I should have latest foreign exchange reference rates
