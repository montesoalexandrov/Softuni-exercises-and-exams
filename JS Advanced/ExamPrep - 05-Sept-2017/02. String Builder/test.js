const StringBuilder = require('./string-builder');
const expect = require('chai').expect;

describe("StringBuilder Tests", function () {
    let builder;
    beforeEach(function () {
        builder = new StringBuilder('test');
    });

    it("It should have initialized all methods", function () {
        expect(Object.getPrototypeOf(builder).hasOwnProperty('append')).to.be.equal(true);
        expect(Object.getPrototypeOf(builder).hasOwnProperty('prepend')).to.be.equal(true);
        expect(Object.getPrototypeOf(builder).hasOwnProperty('insertAt')).to.be.equal(true);
        expect(Object.getPrototypeOf(builder).hasOwnProperty('remove')).to.be.equal(true);
        expect(Object.getPrototypeOf(builder).hasOwnProperty('toString')).to.be.equal(true);
    });

    it("It should return same string", function () {
        expect(builder.toString()).to.be.equal('test');
    });

    it("It should return same string", function () {
        builder = new StringBuilder();
        expect(builder.toString()).to.be.equal('');
    });

    it("It should throw error", function () {
        expect(() => builder = new StringBuilder(5)).to.throw(TypeError);
    });

    it("append", function () {
        builder.append(' string');
        expect(builder._stringArray.length).to.be.equal(11);
        expect(builder.toString()).to.be.equal('test string');
    });

    it("append error", function () {
        expect(() => builder.append({})).to.throw(TypeError);
    });

    it("prepend", function () {
        builder.prepend('string ');
        expect(builder._stringArray.length).to.be.equal(11);
        expect(builder.toString()).to.be.equal('string test');
    });

    it("prepend error", function () {
        expect(() => builder.prepend({})).to.throw(TypeError);
    });

    it("insertAt", function () {
        builder.insertAt('ss', 2);
        expect(builder._stringArray.length).to.be.equal(6);
        expect(builder.toString()).to.be.equal('tessst');
    });

    it("insertAt error", function () {
        expect(() => builder.insertAt([], 2)).to.throw(TypeError);
    });

    it("remove", function () {
        builder.remove(1,2);
        expect(builder._stringArray.length).to.be.equal(2);
        expect(builder.toString()).to.be.equal('tt');
    })
});