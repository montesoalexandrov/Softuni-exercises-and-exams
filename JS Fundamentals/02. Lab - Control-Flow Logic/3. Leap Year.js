function checkYear(year) {
    if(year % 400 === 0) {
        console.log("yes");
    }
    else if(year % 4 === 0 && year % 100 !== 0) {
        console.log("yes");
    }
    else {
        console.log("no")
    }
}

checkYear(1600)
checkYear(1999)
checkYear(2000)
checkYear(1900)