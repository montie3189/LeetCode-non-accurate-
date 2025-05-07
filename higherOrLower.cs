/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        return GuessHelper(1,n);
    }

    public int GuessHelper(int lower, int upper){
        var diff = upper - lower;
        var diffHalved = (diff)/2;
        var midpoint = diffHalved + lower;
        var result = guess(midpoint);
        if (result == 0) return midpoint;
        else if (result == -1) return GuessHelper(lower,midpoint-1);
        else return GuessHelper(midpoint+1,upper);
    }
}
