function getMaxNumber(nums) {
    let maxNum = 0;
    for (let i = 0; i < nums.length; i++) {
        if(i === 0) {
            maxNum = nums[i];
        }
        else if(nums[i] > maxNum) {
            maxNum = nums[i];
        }
    }
    console.log(maxNum)
}
getMaxNumber([130, 5, 99])