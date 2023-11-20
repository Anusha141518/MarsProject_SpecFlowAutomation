@LoginBackground
Feature: This test suite contains add checking language functionality

Scenario: Check user is able to do click on add new button
Given I am on Profile Page
When I click on Languages tab
And I click on Add new button under Languages tab
Then Populate Language input fields

Scenario: Check user is able to add a new language by clicking on add button
Given I am on Profile Page
When I click on Languages tab
And I click on Add new button under Languages tab
Then Populate Language input fields
And I click on Add button
Then I can see that the language can be added and it will visible in the table

Scenario: Check user is able to click on Cancel button
Given I am on Profile Page
When I click on Languages tab
And I click on Add new button under Languages tab
And I click on Cancel button
Then I can see that form will be delete from language tab

Scenario: Check user is able to Edit the existing language in the table
Given I am on Profile Page
When I click on Languages tab
And I click on Add new button under Languages tab
Then Populate Language input fields
And I click on Add button
Then I can see that the language can be added and it will visible in the table
And I click on Edit option
Then I should be able to see update and cancel options
And I update the value in the input fields
When I click on update option
Then I can see update value saved

Scenario: Check user is able to remove the existing language in the table
Given I am on Profile Page
When I click on Languages tab
And I click on Add new button under Languages tab
Then Populate Language input fields
And I click on Add button
Then I can see that the language can be added and it will visible in the table
When I click on Remove option
Then I see that the row has delete from the table







