import ("fmt";
    "slices")

func maxOperations(nums []int, k int) int {
    arr:= make([]int,0)
    sol:=0
    for i:= 0; i< len(nums); i++{
        if nums[i] < k{
            pos, found := slices.BinarySearch(arr, nums[i])
            if found{
                arr = remove(arr,pos)
                sol++
            }else{
                arr = addInPos(arr,k-nums[i])
            }
        }
    }
    return sol
}

func addInPos(s []int, val int) []int{
    i, _ := slices.BinarySearch(s, val)
    return slices.Insert(s, i, val)
}

func remove(s []int, i int) []int {
    return append(s[:i], s[i+1:]...)
}
