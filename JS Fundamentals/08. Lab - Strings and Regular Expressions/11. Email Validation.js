function emailValidation(str) {
    let regex = /^[a-zA-Z0-9]+@[a-zA-Z]+\.[a-zA-Z]+/;
    if(regex.test(str)) {
        console.log('Valid');
    } else {
        console.log('Invalid')
    }
}

emailValidation('valid@email.bg');
emailValidation('invalid@emai1.bg');