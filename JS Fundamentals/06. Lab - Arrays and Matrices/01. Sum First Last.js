function sumTwoNums(numbers) {
    let firstNum = Number(numbers[0]);
    let lastNum = Number(numbers[numbers.length - 1]);
    let sum = firstNum + lastNum;

    console.log(sum);
}
sumTwoNums([10, 5])