function listProcessor(arr) {
    let commandExecutor = (function () {
        let arr = [];
        function add(str) {
            arr.push(str);
        }
        function remove(str) {
            arr = arr.filter(w => w !== str);
        }
        function print() {
            console.log(arr.join(','));
        }
        return {add, remove, print}
    }());

    for (let str of arr) {
        let [command, value] = str.split(' ');
        commandExecutor[command](value);
    }
}

listProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print']);
listProcessor(['add pesho', 'add gosho', 'add pesho', 'remove pesho','print']);