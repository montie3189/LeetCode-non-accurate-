public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] n = s.ToArray();
        int i = 0;
        int j = s.Length - 1;
        while (i < j){
            if (isVowel(n[i]) && isVowel(n[j]))
            {
                char temp = s[i];
                n[i] = n[j];
                n[j] = temp;
                i++;
                j--;
                            }
            if (!isVowel(n[i]))
            {
                i++;
            }
            if (!isVowel(n[j]))
            {
                j--;
            }
            Console.WriteLine(i + ":" + j);
        }
        string answer = new string(n);
        return answer;
    }
    public bool isVowel(char c)
    {
        if (c == 'a' || c == 'e' ||
        c == 'i' || c == 'o' ||
        c == 'u' || c == 'A' ||
        c == 'E' || c == 'I' ||
        c == 'O' || c == 'U') { return true; }
        return false;
    }
}