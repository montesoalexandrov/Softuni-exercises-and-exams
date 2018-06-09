function userNames(arr) {
    for (const ind in arr) {
        let [username, rest] = arr[ind].split('@');
        arr[ind] = username + '.' + rest.split('.').map(a => a[0]).join('');
    }
    console.log(arr.join(', '));
}

userNames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);