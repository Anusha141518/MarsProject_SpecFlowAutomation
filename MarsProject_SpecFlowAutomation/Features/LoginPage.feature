Feature: This test suit contains to check Login Functionality Page

Scenario Outline: A. Check user is able to login page with valid username and valid password
	Given I am on the Mars home page and able to see Signin and Join buttons
	And I choose Signin option
	When I login with valid <username> and valid <password>
	And I click on submit button
	Then I click on dashboard button

	Examples:
	| username                  | password   |
	| anupolavarapu19@gmail.com | Anu@141518 |

	Scenario Outline: B. Check user is able to login page with valid username and invalid password
	Given I am on the Mars home page and able to see Signin and Join buttons
	And I choose Signin option
	When I login with valid <username> and invalid <password>
	And I click on submit button
	And I click on valid username and click on sendverificationemail button
	Then I see message has been sent to the verification mail

Examples:
	| username                  | password |
	| anupolavarapu19@gmail.com | Anu@1415 |

	Scenario Outline: C. Check user is able to login page with invalid username and valid password
	Given I am on the Mars home page and able to see Signin and Join buttons
	And I choose Signin option
	When I login with invalid <username> and valid <password>
	And I click on submit button
	And I click on valid username and click on sendverificationemail button
	Then I see message has been sent to the verification mail

Examples:
	| username                  | password	|
	| anupola@gmail.com			| Anu@141518|

	Scenario Outline: D. Check user is able to login page with invalid username and invalid password
	Given I am on the Mars home page and able to see Signin and Join buttons
	And I choose Signin option
	When I login with invalid <username> and invalid <password>
	And I click on submit button
	And I click on valid username and click on sendverificationemail button
	Then I see message has been sent to the verification mail

Examples:
	| username                  | password |
	| anupola@gmail.com			| Anu@1415 |

	Scenario Outline: E. Check user is able to login page with empty username and valid password
	Given I am on the Mars home page and able to see Signin and Join buttons
	And I choose Signin option
	When I login with null <username> and valid <password>
	Then I can see email validation text

Examples:
	| username                  | password	|
	|							| Anu@141518 |
	Scenario Outline: F. Check user is able to login page with valid username and empty password
	Given I am on the Mars home page and able to see Signin and Join buttons
	And I choose Signin option
	When I login with valid <username> and empty <password>
	And I click on submit button
	Then I can see password validation text

Examples:
	| username                  | password	|
	|anupolavarapu19@gmail.com	||

Scenario Outline: G. Check user is able to login page with empty username and empty password
	Given I am on the Mars home page and able to see Signin and Join buttons
	And I choose Signin option
	When I login with empty <username> and empty <password>
	And I click on submit button
	Then I can see email and password validation text

Examples:
	| username                  | password	|
	|||


