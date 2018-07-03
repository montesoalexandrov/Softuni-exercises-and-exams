function solve(input) {
    let numbers = [];
    let isValid = false;

    for (let line of input) {
        if (Number.isInteger(line)) {
            numbers.push(line);
            if (numbers.length > 1) {
                isValid = true;
            }
        } else {
            if (numbers.length > 1) {
                let result = [];
                switch (line) {
                    case '+':
                        result = numbers.splice(numbers.length - 2, 2);
                        numbers.push(result.reduce((a, b) => a + b));
                        result.splice(0);
                        break;
                    case '-':
                        result = numbers.splice(numbers.length - 2, 2);
                        numbers.push(result.reduce((a, b) => a - b));
                        break;
                    case '*':
                        result = numbers.splice(numbers.length - 2, 2);
                        numbers.push(result.reduce((a, b) => a * b));
                        break;
                    case '/':
                        result = numbers.splice(numbers.length - 2, 2);
                        numbers.push(result.reduce((a, b) => a / b));
                        break;
                }
            } else {
                isValid = false;
            }
        }
    }

    if (isValid === false) {
        console.log("Error: not enough operands!");
    } else if (numbers.length === 1 && isValid === true) {
        console.log(numbers[0]);
    } else if (numbers.length > 1) {
        console.log("Error: too many operands!");
    }
}

solve([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+', '+',]);
solve([3, 4, '+']);
solve([5, 3, 4, '*', '-']);
solve([7, 33, 8, '-']);
solve([15, '/']);