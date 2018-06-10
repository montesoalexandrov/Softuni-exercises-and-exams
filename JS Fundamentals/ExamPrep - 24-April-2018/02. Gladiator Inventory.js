function gladiatorInventory(arr) {
    let inventory = arr.shift().split(' ');

    let allCommands = {
        'Buy': function (item) {
            if(!inventory.includes(item)) {
                inventory.push(item);
            }
        },
        'Trash': function (item) {
            if(inventory.includes(item)) {
                let index = inventory.indexOf(item);
                inventory.splice(index, 1);
            }
        },
        'Repair': function (item) {
            if(inventory.includes(item)) {
                let index = inventory.indexOf(item);
                inventory.splice(index, 1);
                inventory.push(item);
            }
        },
        'Upgrade': function (item) {
            let name = item.split('-');
            if(inventory.includes(name[0])) {
                let index = inventory.indexOf(name[0]);
                item = item.replace('-', ':');
                inventory.splice(index + 1, 0, item);
            }
        },
        'Fight!': function () {
            console.log(inventory.join(" "));
        }
    };

    for (let string of arr) {
        let [command, item] = string.split(' ');
        allCommands[command](item);
    }
}

gladiatorInventory([
    'SWORD Shield Spear',
    'Buy Bag',
    'Trash Shield',
    'Repair Spear',
    'Upgrade SWORD-Steel',
    'Fight!'
]);