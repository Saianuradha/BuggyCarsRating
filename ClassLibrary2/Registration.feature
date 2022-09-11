Feature: Registration
@valid
Scenario Outline: To test the Registarion
	Given I register on the site using Anu2, Anu2, Radha2, Test@123456, Test@123456 as input
	When verify registration is a success
	Then I use created credentials to log in successfully
	
	

