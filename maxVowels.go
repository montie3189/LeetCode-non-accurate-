import ("bytes";
    "fmt")

func maxVowels(s string, k int) int {
    max:=0
    current:= 0
    vowels:= "aeiou"
    for i:= 0; i < len(s); i++{
        if bytes.Contains([]byte(vowels),[]byte{s[i]}){
            current++

        }
        if i > k - 1 && bytes.Contains([]byte(vowels),[]byte{s[i-k]}){
             current--
        }
        if max < current{
            max = current
        }
        
    }
    return max
}
