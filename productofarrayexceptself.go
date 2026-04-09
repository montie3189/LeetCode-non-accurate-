func productExceptSelf(nums []int) []int {
    sol := make([]int,len(nums))
    total := 1
    count := 0
    for i := 0; i< len(nums); i++{
        if nums[i] != 0 {
        total = total * nums[i]
        } else {
            count++
        }
    }

    if count > 1{
        return sol
    }
    for i := 0; i< len(nums); i++{
        if (nums[i] != 0){
            sol[i] = total / nums[i]
            if count > 0{
                sol[i] = 0
            }
        } else {
                if count > 0{
       sol[i] = total
    }
            
        }
    }
    return sol
}