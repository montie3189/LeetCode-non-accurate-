public class Solution {
    public int Tribonacci(int n) {
        if (n ==0){
            return 0;

        }
        else if (n < 3){
            return 1;
        }
        else{
            n = n-2;
            int old1 = 0;
            int old2 = 1;
            int old3 = 1;
            while (n > 0){
                int temp = old1;
                old1 = old2;
                old2 = old3;
                old3 = temp + old1 + old2;
                n--;
            }
            return old3;
        }
        
    }
}
//this solution I believe is best for time and space complexity although it sacrifices readability
