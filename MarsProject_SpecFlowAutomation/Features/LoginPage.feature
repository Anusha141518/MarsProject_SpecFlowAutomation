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

	



