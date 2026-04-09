import "fmt"


func successfulPairs(spells []int, potions []int, success int64) []int {
    sort.Ints(potions);
    var potLen = len(potions)
    answer := make([]int, len(spells))
    for i := 0 ; i < len(spells); i++{
        result:= potLen - int(bSearch(potions,success,int64(spells[i]),0,int64(potLen-1)))
        answer[i] = result
    }
    return answer

}

func bSearch(potions []int,success int64,spell int64,lower int64, upper int64) int64 {
    if upper < lower {
        return lower
    }

    mid := (lower + upper) / 2
    if int64(potions[mid]) * int64(spell) == success {
        if mid > 0 && potions[mid-1] == potions[mid] {
            return bSearch(potions, success, spell, lower, mid-1)
        }
        return mid
    } else if int64(potions[mid]) * spell < success {
        return bSearch(potions, success,spell, mid+1, upper)
    } else {
        return bSearch(potions, success,spell, lower, mid-1)
    }

}