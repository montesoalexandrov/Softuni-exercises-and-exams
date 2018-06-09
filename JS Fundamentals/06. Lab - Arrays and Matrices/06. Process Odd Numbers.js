function processOddNumber(numbers) {
    let result = [];

    for (let i = 0; i < numbers.length; i++) {
        if(i % 2 !== 0) {
            let num = numbers[i];
            result.unshift(num * 2);
        }
    }

    console.log(result);
}

processOddNumber([10, 15, 20, 25]);
processOddNumber([3, 0, 10, 4, 7, 3]);