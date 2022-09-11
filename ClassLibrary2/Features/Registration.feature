Feature: Page Registration
As a visitor
I want to be able to register in the website
So that I can vote for a sport car

@Positive
 Scenario Outline: Register with Valid information
    Given I'm on the Registration page
    When I submit Login "<Login>", First Name "<First Name>", Last Name "<Last Name>", Password "<Password>" ,Confirm Password "<Confirm Password>"
    Then I should see Success message "<message>"

    Examples:
      | Login | First Name | Last Name | Password     | Confirm Password | message|
      | Tester1  | SaiAnuradha       | Jandhyala    | Pa@123456 | Pa@123456     | Registartion Successful|

@Negative
 Scenario Outline: Register with duplicate user information
    Given I'm on the Registration page
    When I submit Login "<Login>", First Name "<First Name>", Last Name "<Last Name>", Password "<Password>" ,Confirm Password "<Confirm Password>"
    Then I should see an error message "<message>"

    Examples:
      | Login | First Name | Last Name | Password     | Confirm Password | message                  |
      | Anu4  | Anu4       | RAdha4    | Test@1234567 | Test@1234567     | InvalidParameterException    |
      | Anu4  | Anu4       | Radha4    | Te@11111 | Te@11111    | User already exists      |
      | Anu4  | Anu4       | Radha4    | Te@1111  | Te@2222     | Password Should match      |
      | Anu4  | Anu4       | RAdha4    | Te@1111         | Te@1111             | minimum password length  |
      | Anu4  | Anu4       | RAdha4    | 11111111         | 11111111             | InvalidPasswordException |
	  | Anu4  | Anu4       | RAdha4    | A1111111         | A1111111             | InvalidPasswordException |
	  | Anu4  | Anu4       | RAdha4    | a1111111         | a1111111             | InvalidPasswordException |

