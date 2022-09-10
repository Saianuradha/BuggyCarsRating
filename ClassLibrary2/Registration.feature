Feature: Registration

@tag1
Scenario: To test the Registarion
	Given I register on the site using:
	When verify registration is a success
	Then I use created credentials to log in successfully