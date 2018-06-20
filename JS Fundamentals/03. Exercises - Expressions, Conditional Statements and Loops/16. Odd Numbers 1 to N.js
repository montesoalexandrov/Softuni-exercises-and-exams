function getOddNumbers(lastNum) {
    for (let i = 0; i <= lastNum; i++) {
        if(i % 2 !== 0) {
            console.log(i)
        }
    }
}
getOddNumbers(5)
getOddNumbers(4)
getOddNumbers(7)