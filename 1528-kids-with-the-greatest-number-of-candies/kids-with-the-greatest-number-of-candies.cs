public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int largest = candies[0];
        foreach (int cand in candies)
        {
            if (cand > largest) largest = cand;

        }

        return  candies.Select(x => (x + extraCandies) >= largest).ToList();

    }
}