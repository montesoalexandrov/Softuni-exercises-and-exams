function getSmallestNums(numbers) {
    numbers = numbers.sort((a, b) => a - b);
    console.log(numbers[0] + ' ' + numbers[1]);
}
getSmallestNums([30, 15, 50, 5]);
getSmallestNums([3, 0, 10, 4, 7, 3])