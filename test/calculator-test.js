var chai = require('chai');
var expect = chai.expect;
var calculator = require('../src/js/calculator');


describe('Adding 2 numbers', function () {
    it('Should return 3 when adding 1 + 2', function () {
        result = calculator.addTest(2, 2);
        expect(result).to.equal(3);
    })
})
