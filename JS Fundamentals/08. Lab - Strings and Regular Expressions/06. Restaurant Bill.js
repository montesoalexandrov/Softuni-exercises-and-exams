function restaurantBill(items) {
    let products = items.filter((e, i) => i % 2 === 0).join(', ');
    let price = items.filter((e, i) => i % 2 === 1).reduce((a, b) => +a + +b);
        console.log(`You purchased ${products} for a total sum of ${price}`)
}

restaurantBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);
restaurantBill(['Cola', '1.35', 'Pancakes', '2.88']);