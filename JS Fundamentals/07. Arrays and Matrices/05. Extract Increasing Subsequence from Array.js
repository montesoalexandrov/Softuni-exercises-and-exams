function extractNondecreasingNumbers(numbers) {
    let biggestNum = Number.NEGATIVE_INFINITY;

    for (let i = 0; i < numbers.length; i++) {
        if(numbers[i] >= biggestNum) {
            biggestNum = numbers[i];
            console.log(numbers[i]);
        }
    }
}

extractNondecreasingNumbers([1, 3, 8, 4, 10, 12, 3, 2, 24]);
extractNondecreasingNumbers([1, 2, 3, 4]);
extractNondecreasingNumbers([20, 3, 2, 15, 6, 1]);