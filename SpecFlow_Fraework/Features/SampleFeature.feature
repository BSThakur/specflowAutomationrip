Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatory details
	#Given I have opend my application
	#Then I should see employee detail page
	When I fill all mandatory details in form
	| Name    |  Age |  Phone      |  Email						   |
	| karthik |  28  |  8921989514 |  karthik@executeautomation.com |
	| Preeth  |  25  |  8921989514 |  Preeth@executeautomation.com  |
	| Kaushik |  29  |  8921989514 |  Kaushik@executeautomation.com |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new employee with mandatory details for different data
	#Given I have opend my application
	#Then I should see employee detail page
	When I fill all mandatory details in form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples:
    | Name     | Age |  Phone      | 
	| karthik  | 28  |  8921989514 | 
	| Preeth   | 25  |  8921989514 | 
	| Kaushik  | 29  |  8921989514 |
