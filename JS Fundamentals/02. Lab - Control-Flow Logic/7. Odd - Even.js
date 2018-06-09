function oddOrEven(num) {
    if (num % 2 === 0){
        console.log("even")
    }
    else if(num % 2 === 1 || num % 2 === -1){
        console.log("odd")
    }
    else{
        console.log("invalid")
    }
}

oddOrEven(5)
oddOrEven(8)
oddOrEven(1.5)