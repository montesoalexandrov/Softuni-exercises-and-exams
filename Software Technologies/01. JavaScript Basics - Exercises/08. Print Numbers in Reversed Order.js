function PrintInReversedOrder(nums) {
    nums.reverse();
    nums.forEach(function(num) {
        console.log(num);
    });
}