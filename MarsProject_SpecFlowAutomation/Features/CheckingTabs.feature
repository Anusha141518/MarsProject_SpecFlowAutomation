@LoginBackground
Feature: This test suit contains to check all tabs navigation Functionality Page

Scenario: Check user is able to navigate all the Tabs
	Given I am on Profile Page
	When I try to click on Languages tab 
	Then I can see Language tab should be active
	When I click on Skills tab
	Then I can see Skills tab should be active
	When I click on Eduction tab
	Then I can see Eduction tab should be active
	When I click on Certifications tab
	Then I can see Certifications tab should be active