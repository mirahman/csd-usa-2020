Feature: Addition feature test 

Scenario: add two positive numbers 
    Given i have number 5 and 6
    When i add them up 
    Then the result will show 11

Scenario: add one positive number and one negative number 
    Given i have number 15 and -6
    When i add them up 
    Then the result will show 9
