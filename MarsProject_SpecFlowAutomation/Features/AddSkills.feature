@LoginBackground
Feature: This test suite contains add checking Skills functionality

Scenario: Check user is able to do click on add new button
Given I am on Profile Page
When I click on Skills Tab
And I click on Add new button under Skills tab
Then Populate Skills input fields

Scenario: Check user is able to add a new Skills by clicking on add button
Given I am on Profile Page
When I click on Skills tab
And I click on Add new button under Skills tab
Then Populate Skills input fields
And I click on Skills Add button
Then I can see that the Skills can be added and it will visible in the table

Scenario: Check user is able to click on Cancel button
Given I am on Profile Page
When I click on Skills tab
And I click on Add new button under Skills tab
And I click on Cancel button under Skills tab
Then I can see that form will be delete from Skills tab

Scenario: Check user is able to Edit the existing language in the table
Given I am on Profile Page
When I click on Skills tab
And I click on Add new button under Skills tab
Then Populate Skills input fields
And I click on Skills Add button 
Then I can see that the language can be added and it will visible in the table
And I click on Skills Edit option
Then I should be able to see update and cancel options under Skills tab
And I update the value in the input fields
When I click on update option under Skills tab
Then I can see update value saved

Scenario: Check user is able to remove the existing language in the table
Given I am on Profile Page
When I click on Skills tab
And I click on Add new button under Skills tab
Then Populate Skills input fields
And I click on Skills Add button 
Then I can see that the language can be added and it will visible in the table
When I click on Remove option under Skills tab
Then I see that the row has delete from the Skills table
