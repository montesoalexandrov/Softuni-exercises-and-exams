function checkNum(numbers) {
    let result = [];
    for (let num of numbers) {
        if (num >= 0) {
            result.push(num);
        } else {
            result.unshift(num);
        }
    }
    console.log(result)
}

checkNum([7, -2, 8, 9])