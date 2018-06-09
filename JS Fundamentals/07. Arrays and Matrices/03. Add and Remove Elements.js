function manipulateArray(input) {
    let numbers = [];

    for (let i = 0; i < input.length; i++) {
        if (input[i] === 'add') {
            numbers[i] = 1 + i;
        } else {
            numbers.pop();
        }
    }
    if(numbers.length === 0) {
        console.log('Empty');
    }
    for (let num of numbers) {
        if(num !== undefined) {
            console.log(num);
        }
    }
}

manipulateArray(['add', 'add', 'add', 'add']);
manipulateArray(['add', 'add', 'remove', 'add', 'add']);
manipulateArray(['remove', 'remove', 'remove']);