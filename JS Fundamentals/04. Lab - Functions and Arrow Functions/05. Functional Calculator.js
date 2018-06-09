function sumNums(num1, num2, op) {
    switch(op) {
        case "+":
            console.log(num1 + num2)
            break
        case "-":
            console.log(num1 - num2)
            break
        case "*":
            console.log(num1 * num2)
            break
        case "/":
            console.log(num1 / num2)
            break
    }
}
sumNums(100, 5, "/")