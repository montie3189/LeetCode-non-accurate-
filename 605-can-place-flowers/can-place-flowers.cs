public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    { 
        int count = 0;
        for (int i = 0; i <flowerbed.Length;i++)
        {
            if (flowerbed[i] == 1)
            {
                if(i>0)flowerbed[i-1] = 2;
                if(i < flowerbed.Length -1) flowerbed[i + 1] = 2;
                
            }
            else if (flowerbed[i] == 0 ) {
                if(i < flowerbed.Length -1&& flowerbed[i+1] == 0) flowerbed[i+1] = 2 ;
                if(i<flowerbed.Length -1 && flowerbed[i+1] != 1)
                count++;
                else if (i == flowerbed.Length - 1) count++;
            }
        }
        if (count >= n)return true;
        return false;
    }
}