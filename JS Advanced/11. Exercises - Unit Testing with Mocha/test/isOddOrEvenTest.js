let expect = require('chai').expect;
let isOddOrEven = require("../02. Even Or Odd").isOddOrEven;

describe('isOddOrEven', function () {
    it('with a number parameter, should return undefined', function () {
        expect(isOddOrEven(13)).to.equal(undefined, "Function did not return the correct result!");
    });
    it('with a object parameter, should return undefined', function () {
        isOddOrEven({name: 'pesho'}).should.equal(undefined, "Function did not return the correct result!");
    });
    it('with an even length string should return "even"', function () {
        assert.equal(isOddOrEven("roar"), "even", "Function did not return correct result!");
    });
    it('with an odd length string, should return "odd"', function () {
        expect(isOddOrEven("pesho")).to.equal("odd", "Function did not return correct result!");
    });
    it('with multiple consecutive checks, should return correct values', function () {
        expect(isOddOrEven("cat")).to.equal('odd', "Function did not return correct result!");
        expect(isOddOrEven("alabala")).to.equal("odd", "Function did not return correct result!");
        expect(isOddOrEven("is it even")).to.equal("even", "Function did not return correct result!");
    });
});