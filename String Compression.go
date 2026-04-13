import ("fmt";
"strconv")

func compress(chars []byte) int {
    if len(chars)==1{
        return 1
    }
    var s []byte
    var last = byte(' ')
    var count = 1
    for i:= 0; i < len(chars); i++{
        if chars[i] == last{
            count++
        }else{
            s = append(s,last)
            numString:=countHandler(count)
            s= append( s,numString...)
            count = 1
            last = chars[i]
        }
        
    }
        s = append(s,last)
        numString:=countHandler(count)
        s= append(s,numString...)
        fmt.Println(string(s))
    for i:= 0; i < len(s)-1; i++{
        chars[i] = s[i+1]
    }
    return len(s)-1
}

func countHandler(count int) []byte {
    if count == 1 {
        return []byte{}
    }
    bs := []byte(strconv.Itoa(count))
    return bs
}
