function solve(obj) {
    let car = {};
    car.model = obj.model;
    car.engine = carEngine();
    car.carriage = carCarriage();
    car.wheels = wheelSize();

    console.log(car);
    return car;

    function carEngine() {
        if (obj.power <= 90) {
            return {power: 90, volume: 1800};
        }
        else if (obj.power > 90 && obj.power <= 120) {
            return {power: 120, volume: 2400};
        } else {
            return {power: 200, volume: 3500};
        }
    }

    function carCarriage() {
        return {type: obj.carriage, color: obj.color};
    }

    function wheelSize() {
        let wheels = [];
        if (obj.wheelsize % 2 === 0) {
            obj.wheelsize -= 1;
        }
        for (let i = 0; i < 4; i++) {
            wheels.push(obj.wheelsize);
        }

        return wheels;
    }
}

solve({
        model: 'VW Golf II',
        power: 90,
        color: 'blue',
        carriage: 'hatchback',
        wheelsize: 14
    }
);
solve({
        model: 'Opel Vectra',
        power: 110,
        color: 'grey',
        carriage: 'coupe',
        wheelsize: 17
    }
);