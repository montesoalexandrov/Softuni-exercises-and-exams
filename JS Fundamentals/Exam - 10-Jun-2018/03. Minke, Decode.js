function solve(arr) {
    let startIndex = Number(arr[0]);
    let endIndex = Number(arr[1]);
    let rightWord = arr[2];
    let text = arr[3];
    let regexNumber = /[0-9]{3}\.?[0-9]*/g;
    let regexCountry = /[A-Z]{1}[a-z]+[A-Z]{1}/g;
    let city = "";
    let matches = text.match(regexNumber);
    let countryMatch = regexCountry.exec(text);
    let country = countryMatch[0];

    for (let match of matches) {
        let num = Math.ceil(Number(match));

        let char = String.fromCharCode(num);
        city += char;
        city = city.charAt(0).toUpperCase() + city.substr(1);
    }

    let part = country.substring(startIndex, endIndex + 1);
    let countryResult = country.replace(part, rightWord);
    countryResult = countryResult.toLowerCase();
    countryResult = countryResult.charAt(0).toUpperCase() + countryResult.substr(1);
    console.log(`${countryResult} => ${city}`);

}