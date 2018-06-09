function print(numbers) {
    let numOfElements = numbers[0];
    delete numbers[0];

    let firstNumbers = [];
    let lastNumbers = [];

    for (let i = 1; i <= numOfElements; i++) {
        firstNumbers.push(numbers[i]);
    }

    for (let i = numbers.length - numOfElements; i <= numOfElements + 1; i++) {
        lastNumbers.push(numbers[i])
    }

    console.log(firstNumbers);
    console.log(lastNumbers);
}

print([3, 6, 7, 8, 9]);
print([2, 7, 8, 9]);