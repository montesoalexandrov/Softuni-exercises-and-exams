const Sumator = require('./Sumator');
const expect = require('chai').expect;

describe("Sumator Unit Tests", function () {
    let sumator;
    beforeEach(function () {
        sumator = new Sumator();
    });

    describe("check if functions exist", function () {
        it("data is not undefined", function () {
            expect(sumator.data !== undefined).to.equal(true)
        });

        it("add func exists", function () {
            expect(Sumator.prototype.hasOwnProperty('add')).to.be.equal(true);
        });

        it("sumNums func exists", function () {
            expect(Sumator.prototype.hasOwnProperty('sumNums')).to.be.equal(true);
        });

        it("removeByFilter func exists", function () {
            expect(Sumator.prototype.hasOwnProperty('removeByFilter')).to.be.equal(true);
        });

        it("toString func exists", function () {
            expect(Sumator.prototype.hasOwnProperty('toString')).to.be.equal(true);
        });
    });

    it("Test if data length is empty", function () {
        expect(sumator.data.length).to.be.equal(0);
    });

    describe("add func tests", function () {
        it("add only numbers", function () {
            sumator.add(5);
            sumator.add(4);
            sumator.add(3);
            expect(sumator.data.join(', ')).to.be.equal('5, 4, 3')
        });

        it("add only strings", function () {
            sumator.add('pesho');
            sumator.add('ivan');
            sumator.add('petkan');
            expect(sumator.data.join(', ')).to.be.equal('pesho, ivan, petkan')
        });

        it("add only objects", function () {
            sumator.add({name: "Pesho"});
            sumator.add({});
            expect(sumator.data.join(', ')).to.be.equal('[object Object], [object Object]')
        });

        it("add mixed types", function () {
            sumator.add({name: "Pesho"});
            sumator.add(4);
            sumator.add("Ivan");
            expect(sumator.data.join(', ')).to.be.equal('[object Object], 4, Ivan')
        });
    });

    describe("Sum nums Tests", function () {
        it("sum with numbers", function () {
            sumator.add(5);
            sumator.add(4);
            sumator.add(3);
            sumator.add(2);
            sumator.add(1);
            expect(sumator.sumNums()).to.be.equal(15);
        });

        it("sum every without nums", function () {
            sumator.add("gosho");
            sumator.add({});
            sumator.add({name: "Gosho"});
            expect(sumator.sumNums()).to.be.equal(0);
        });

        it("sum mixed types", function () {
            sumator.add("gosho");
            sumator.add(8);
            sumator.add({});
            sumator.add(3);
            expect(sumator.sumNums()).to.be.equal(11);
        });
    });

    describe("remove by filter tests", function () {
        it('removes all odd numbers', function () {
            for (let i = 0; i <= 10; i++) {
                sumator.add(i);
            }

            sumator.removeByFilter((x) => x % 2 !== 0);
            expect(sumator.data.join(', ')).to.be.equal('0, 2, 4, 6, 8, 10');
        });

        it('removes numbers greater then 5', function () {
            for (let i = 0; i <= 5; i++) {
                sumator.add(i);
            }

            sumator.removeByFilter((x) => x > 5);
            expect(sumator.data.join(', ')).to.be.equal('0, 1, 2, 3, 4, 5');
        });

        it('throws exceptions', function () {
            for (let i = 0; i <= 5; i++) {
                sumator.add(i);
            }

            expect(() => sumator.removeByFilter(undefined).to.throw());
        });
    });

    describe("test toString func", function () {
        it("with empty array", function () {
            expect(sumator.toString()).to.be.equal('(empty)');
        })
    });
});