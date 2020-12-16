const assert = require('assert');
const calculator = require('./calculator');

it('should add two positive numbers ', function () {
    assert.equal(4, calculator.add(2, 2));
});

it('should add one positive number and one negative ', function () {
    assert.equal(3, calculator.add(6, -3));
});

it('should add one positive integer and one fraction ', function () {
    assert.equal(10.7, calculator.add(6, 4.7));
});

it('should add one positive integer and character ', function () {
    assert.equal(10, calculator.add('6', '4'));
});

it('should add two character ', function () {
    assert.equal(NaN, calculator.add('A', 'B'));
});


