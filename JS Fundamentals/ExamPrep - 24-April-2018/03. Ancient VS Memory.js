function solve(arr) {
    let result = '';
    for (let string of arr) {
        let numbers = string.split(' ');
        for (let number of numbers) {
            if(number !== '0' && number !== '32656' && number !== '19759' && number !== '32763' && number > 31)
            {
                let charIndex = Number(number);
                result += String.fromCharCode(charIndex);
            }
        }
        console.log(result);
        result = '';
    }
}

solve([
    '32656 19759 32763 0 5 0 80 101 115 104 111 0 0 0 0 0 0 0 0 0 0 0',
    '0 32656 19759 32763 0 7 0 83 111 102 116 117 110 105 0 0 0 0 0 0 0 0'
])