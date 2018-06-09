function SumNumbers(nums) {
    let n = nums[0];
    let x = nums[1];
    let result;

    if (n > x)
    {
        result = n / x;
    }
    else
    {
        result = n * x;
    }

    console.log(result)
}