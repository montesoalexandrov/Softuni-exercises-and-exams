function getFeet(totalInches) {
    let feet = Math.floor(totalInches / 12);
    let inches = totalInches % 12;

    return `${feet}'-${inches}"`;
}

console.log(getFeet(36));
console.log(getFeet(55));
console.log(getFeet(11));