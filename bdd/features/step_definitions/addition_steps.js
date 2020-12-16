const { Before, Given, When, Then } = require('@cucumber/cucumber');
const expect = require('chai').expect;
const Calculator = require('../../Calcualtor');
let calculator;

Given('i have number {} and {}', function (numOne, numTwo) {
    calculator = new Calculator(numOne, numTwo);
});



When('i add them up', function () {
    // Write code here that turns the phrase above into concrete actions
    //return 'pending';
    calculator.add();
});

Then('the result will show {}', function (result) {
    // Then('the result will show {float}', function (float) {
    // Write code here that turns the phrase above into concrete actions
    //return 'pending';
    expect(calculator.result).to.be.equal(+result);
});


