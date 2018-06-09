function getDistance(input) {
    let x1 = input[0];
    let y1 = input[1];
    let z1 = input[2];
    let x2 = input[3];
    let y2 = input[4];
    let z2 = input[5];

    let distance = Math.sqrt(
        ((x2 - x1) * (x2 - x1)) +
        ((y2 - y1) * (y2 - y1)) +
        ((z2 - z1) * (z2 - z1))
    );

    console.log(distance)
}

getDistance([1, 1, 0, 5, 4, 0])
getDistance([3.5, 0, 1, 0, 2, -1])