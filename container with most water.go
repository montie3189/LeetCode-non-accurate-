import "fmt"

func maxArea(height []int) int {
    arrLen := len(height)
    vol := min(height[0],height[arrLen-1]) * (arrLen-1)
    if height[0] < height[arrLen-1]{
        for i:=0; i <arrLen;i++{
            if height[0] < height[i]{
                vol = max(vol,maxArea(height[i:arrLen]))
                break
            }
        }

    }else{
        for i:=arrLen-1; i >= 0;i--{
            if height[arrLen-1] < height[i]{
                vol = max(vol,maxArea(height[0:i+1]))
                break
            }
        }

    }
    return vol
}

func min(a, b int) int {
    if a < b {
        return a
    }
    return b
}
func max(a, b int) int {
    if a > b {
        return a
    }
    return b
}
