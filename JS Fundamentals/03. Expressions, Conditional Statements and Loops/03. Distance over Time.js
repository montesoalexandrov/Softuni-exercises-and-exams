function getDistanceInMeter(input) {
    let first = input[0]
    let second = input[1]
    let time = input[2] * 1.0 / 60 / 60

    let firstDistance = first * time
    let secondDistance = second * time

    console.log(Math.abs(firstDistance - secondDistance) * 1000)
}

getDistanceInMeter([0, 60, 3600])
getDistanceInMeter([11, 10, 120])
getDistanceInMeter([5, -5, 40])