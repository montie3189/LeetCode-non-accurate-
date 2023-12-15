public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int hf1 = str1.Length;
        int hf2 = str2.Length;
        int s1Len = str1.Length;
        int s2Len = str2.Length;
        while (hf1 != 1 && hf2 !=1){
            if (hf1<hf2)
            hf2 = nextLowestFactor(s2Len,hf1);
            else if (hf1 == hf2){
                if (cchecked(str1,str2,hf1))
                return str1.Substring(0,hf1);
                else hf2 = nextLowestFactor(s2Len,hf1 -1);
            }
            else hf1 = nextLowestFactor(s1Len,hf2);
        }
        if (cchecked(str1,str2,1)) return str1.Substring(0,1);
        return "";
    }

    public int nextLowestFactor (int len, int start){
        Console.WriteLine(len + ": " + start);
        while (start>1){
            if (len % start == 0) return start;
            else start--;
        }
        return 1;
    }

    public bool cchecked (string str1, string str2, int len){
        if (str1.Substring(0,len) != str2.Substring(0,len)) return false;

        for (int i = len ; i<=(str1.Length - len);){
            if (str1.Substring(i,len)!= str1.Substring(0,len)) return false;
            i+=len;
        }
                for (int i = len ; i<=(str2.Length - len);){
            if (str2.Substring(i,len)!= str2.Substring(0,len)) return false;
            i+=len;
        }
        return true;
    }

}