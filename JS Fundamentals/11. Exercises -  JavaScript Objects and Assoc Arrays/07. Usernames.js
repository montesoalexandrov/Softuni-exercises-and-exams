function createCatalogue(input) {
    let usernames = new Set();

    for (let name of input) {
        usernames.add(name);
    }
    let sortedUsers = [...usernames].sort((a, b) => sortUsernames(a, b));
    console.log(sortedUsers.join("\n"));

    function sortUsernames(nameOne, nameTwo) {
        if (nameOne.length === nameTwo.length) {
            return nameOne.localeCompare(nameTwo);
        }
        return nameOne.length - nameTwo.length;
    }
}


createCatalogue([
    'Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston'
]);