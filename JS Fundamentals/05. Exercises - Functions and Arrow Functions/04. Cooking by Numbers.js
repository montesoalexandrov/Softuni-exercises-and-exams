function coockingByNumbers(arr) {
    let [number, op1, op2, op3, op4, op5] = [Number(arr[0]), arr[1], arr[2], arr[3], arr[4], arr[5]]
    let numberForOperations = number;

    let chop = (num) => num / 2;
    let dice = (num) => Math.sqrt(num);
    let spice = (num) => num + 1;
    let bake = (num) => num * 3;
    let fillet = (num) => num * 0.8;

    for (let op of [op1, op2, op3, op4, op5]) {
        switch (op) {
            case 'chop' :
                numberForOperations = chop(numberForOperations);
                console.log(numberForOperations);
                break;
            case 'dice' :
                numberForOperations = dice(numberForOperations);
                console.log(numberForOperations);
                break;
            case 'spice' :
                numberForOperations = spice(numberForOperations);
                console.log(numberForOperations);
                break;
            case 'bake' :
                numberForOperations = bake(numberForOperations);
                console.log(numberForOperations);
                break;
            case 'fillet' :
                numberForOperations = fillet(numberForOperations);
                console.log(numberForOperations);
                break;
        }
    }
}

coockingByNumbers([32, 'chop', 'chop', 'chop', 'chop', 'chop'])