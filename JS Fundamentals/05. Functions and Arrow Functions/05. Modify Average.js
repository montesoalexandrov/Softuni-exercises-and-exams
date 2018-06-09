function modify(number) {
    let numberAsString = number.toString();

    function getAVG(numberAsString) {
        let sum = 0;
        for (let digit of numberAsString) {
            sum += Number(digit);
        }
        return sum / numberAsString.length;
    }

    let addNine = (num) => num + '9';
    let average = getAVG(numberAsString);
    while (average <= 5) {
        numberAsString = addNine(numberAsString);
        average = getAVG(numberAsString);
    }
    console.log(numberAsString);
}

modify(101);