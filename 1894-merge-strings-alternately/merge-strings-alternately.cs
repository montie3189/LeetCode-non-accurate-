using System;
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int j =0;
        int len = word2.Length;
        StringBuilder answer = new StringBuilder();
        foreach (char letter in word1){
            answer.Append( letter);
            if(j<len){ answer .Append( word2[j] );
            j++;}
        }
        if (j<len) answer.Append(word2.Substring(j,len -j));
        return answer.ToString();
    }
} 