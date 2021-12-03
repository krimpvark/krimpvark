Feature: InteristRate

![InteristRate]
Simple Calculation of Interist Rate

@InteristRate
Scenario: Calculate Interist Rate
	Given the opening balance is 100
	And the rate is 10
	And the startDate is 2021-05-01
	And the endDate is 2021-05-15
	When the Interist rate is calculated
	Then the result should be 417.7248169415651