function sumArea(a, b, c) {
    let p = (a + b + c) / 2
    let area = Math.sqrt(p*(p-a)*(p-b)*(p-c))
    console.log(area)
}

sumArea(2, 3.5, 4)