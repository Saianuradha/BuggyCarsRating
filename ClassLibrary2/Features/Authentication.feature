Feature: Authentication

A short summary of the feature

@Login @Valid
Scenario Outline: To test the Login fuctionality with valid credentials
	Given I'm on Buggy Cars Rating home page
    When I enter User Name "<UserName>" and Password "<Password>"
    Then I should be able to login successfully.

    Examples:
      | UserName | Password   | 
      | Anu4     | Test@1234567 |
	
@Login @Invalid
Scenario Outline: To test the Login with invalid credentials
	Given I'm on Buggy Cars Rating home page
    When I enter User Name "<UserName>" and Password "<Password>"
    Then I should not be able to login successfully.
	Examples:
      | UserName | Password   | 
      | Tester     | Test@12345678 |
      
@Logout @Valid
Scenario: To test logout with click
    Given I'm on Buggy Cars Rating home page
    When I enter User Name "<UserName>" and Password "<Password>"
    Then I should be able to login successfully.
    When I click on the Logout button.
	Then I should be logged off
     Examples:
      | UserName | Password   | 
      | Anu4     | Test@1234567 |
   