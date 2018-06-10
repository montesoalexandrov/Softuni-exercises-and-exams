function countryMarket(input) {
    let countries = new Map();

    for (let i = 0; i < input.length; i++) {
        let [country, city, price] = input[i].split(" > ");
        city = city.charAt(0).toUpperCase() + city.slice(1);

        if (!countries.has(country)) {
            countries.set(country, new Map());
        }
        if (!countries.get(country).has(city)) {
            countries.get(country).set(city, Number(price));
        }
        let oldPrice = countries.get(country).get(city);
        if (oldPrice > price) {
            countries.get(country).set(city, price)
        }
    }

    let sortedCountries = [...countries].sort();

    for (let [country, cities] of sortedCountries) {
        let res = '';
        for (let [city, price] of cities) {
            res += `${city} -> ${price} `;
        }
        console.log(`${country} -> ${res}`);
    }
}