Feature: Addition feature outline test 

Scenario Outline: add two numbers 
    Given i have number <one> and <two>
    When i add them up 
    Then the result will show <result>

Examples:
    |one|two|result|
    |5|6|11|
    |10|-6|4|
    |-5|-10|-15|
    |2.5|3|5.5|
    |4.1|5.7|9.8|
