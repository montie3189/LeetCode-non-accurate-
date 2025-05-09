public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var currentPos = cost.Length;
        if (currentPos == 0) return 0;
        else if (currentPos == 1) return cost[0];
        else {
            int[] Tcosts = new int[currentPos + 1];
            Tcosts[currentPos] = 0;
            Tcosts[--currentPos] = cost[currentPos];
            while(currentPos>0){
                currentPos--;
                if (Tcosts[currentPos+1] < Tcosts[currentPos+2]) Tcosts[currentPos] = cost[currentPos] + Tcosts[currentPos+1];
                else Tcosts[currentPos] = cost[currentPos] + Tcosts[currentPos+2];
            }
            if (Tcosts[0] < Tcosts[1]) return Tcosts[0];
            else return Tcosts[1];
        }
    }
}
