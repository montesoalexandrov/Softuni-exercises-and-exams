function validate() {
    let username = $('#username');
    let email = $('#email');
    let password = $('#password');
    let confirmPassword = $('#confirm-password');
    let companyCheckbox = $('#company');
    let companyNumber = $('#companyNumber');
    let companyInfo = $('#companyInfo');
    let submitBtn = $('#submit');
    let validationDiv = $('#valid');

    let allIsValid = true;

    companyCheckbox.on('change', function () {
        if (companyCheckbox.is(':checked')) {
            companyInfo.css('display', 'block');
            validateCompanyInfo();
        } else {
            companyInfo.css('display', 'none');
        }
    });

    submitBtn.on('click', function (ev) {
        ev.preventDefault();
        validateForm();
        validationDiv.css('display', allIsValid ? 'block' : 'none');
        allIsValid = true;
    });

    function validateForm() {
        validateInputWithRegex(username, /^[A-Za-z\d]{3,20}$/g);
        validateInputWithRegex(email, /^.*?@.*?\..*$/g);
        if (confirmPassword.val() === password.val()) {
            validateInputWithRegex(password, /^\w{5,15}$/g);
            validateInputWithRegex(confirmPassword, /^\w{5,15}$/g);
        } else {
            password.css('border', '1px solid red');
            confirmPassword.css('border', '1px solid red');
            allIsValid = false;
        }
    }

    function validateInputWithRegex(input, pattern) {
        if (pattern.test(input.val())) {
            input.css('border', 'none');
        } else {
            input.css('border', '1px solid red');
            allIsValid = false;
        }
    }

    function validateCompanyInfo() {
        let numValue = Number(companyNumber.val());
        if (numValue >= 1000 && numValue <= 9999) {
            companyNumber.css('border', 'none');
        } else {
            companyNumber.css('border', '1px solid red');
            allIsValid = false;
        }
    }
}