function createRegister(input) {
    let carRegister = new Map();

    for (let line of input) {
        let [brand, model, quantity] = line.split(" | ");
        quantity = Number(quantity);
        if (!carRegister.has(brand)) {
            carRegister.set(brand, new Map());
        }
        if (!carRegister.get(brand).has(model)) {
            carRegister.get(brand).set(model, 0);
        }
        carRegister.get(brand).set(model, carRegister.get(brand).get(model) + quantity);
    }
    for (let [brand, modelAndQuantity]of carRegister) {
        console.log(brand);

        for (let [model, number] of modelAndQuantity) {
            console.log(`###${model} -> ${number}`);
        }
    }
}

createRegister([
    'Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
]);