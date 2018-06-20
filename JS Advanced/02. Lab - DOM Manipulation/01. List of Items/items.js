function addItem() {
    let value = document.getElementById('newItemText').value;
    let li = document.createElement('li');
    li.textContent = value;
    document.getElementById('items').appendChild(li);
}