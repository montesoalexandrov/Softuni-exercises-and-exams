function splitString(text, delimiter) {
    let arr = text.split(delimiter);

    for (const str of arr) {
        console.log(str);
    }
}

splitString('One-Two-Three-Four-Five', '-');
splitString('http://platform.softuni.bg', '.');