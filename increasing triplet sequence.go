import "fmt"
func increasingTriplet(nums []int) bool {
    if len(nums) < 3 {
        return false
    }
    var sols = [][]int {{nums[0]}}
    for i:= 1; i < len(nums); i++{
        for j:= range sols{
            if sols[j][0] >= nums[i]{
                sols[j][0] = nums[i]
                break
            }else if sols[j][0] < nums[i]{
                if len(sols[j])>=2{return true}
                nextSol := append([]int{nums[i]},sols[j]...)
                sols = append(sols,nextSol)
            }
        }
    }
    return false
}