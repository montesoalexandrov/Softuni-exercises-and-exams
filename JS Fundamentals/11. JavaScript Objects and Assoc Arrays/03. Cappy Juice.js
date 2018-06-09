function cappyJuice(arr) {
    let bottles = new Map();
    let fruits = new Map();

    for (let line of arr) {
        let [fruit, quantity] = line.split(' => ');

        if (!fruits.has(fruit)) {
            fruits.set(fruit, 0);
        }
        fruits.set(fruit, fruits.get(fruit) + Number(quantity));

        let sumQuantity = Number(fruits.get(fruit));

        if (sumQuantity >= 1000) {
            let bottle = ~~(sumQuantity / 1000); // Операторът ~~ закръгля на цяло чидло!

            if (!bottles.has(fruit)) {
                bottles.set(fruit, 0);
            }
            bottles.set(fruit, bottles.get(fruit) + bottle);
            let juiceLeft = sumQuantity % 1000;
            fruits.set(fruit, juiceLeft);
        }
    }

    for (let fruit of bottles) {
        console.log(`${fruit[0]} => ${fruit[1]}`)
    }
}

cappyJuice([
    'Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549'
]);