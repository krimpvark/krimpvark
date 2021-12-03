Feature: InterestRate

![InterestRate]
Simple Calculation of Interest Rate

@InterestRate
Scenario: Calculate Interest Rate
	Given the opening balance is 100
	And the rate is 10
	And the startDate is 2021-05-01
	And the endDate is 2021-05-15
	When the Interest rate is calculated
	Then the result should be 417.7248169415651