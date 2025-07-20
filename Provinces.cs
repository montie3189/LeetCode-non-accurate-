public class Solution {
    public int FindCircleNum(int[][] isConnected) {
    
        int provinces = 0;
        Queue<int> cities = new Queue<int> ();
int nextProv = nextProvince(isConnected);
        while (nextProv!= -1){
            provinces++;
        cities.Enqueue(nextProv);

        
        while(cities.Count>0){
            int city = cities.Dequeue();
            isConnected[city][city]=0;
            for (int i = 0; i<isConnected[city].Length;i++){
                if (isConnected[city][i] == 1){
                    cities.Enqueue(i);
                    isConnected[city][i]=0;
                    isConnected[i][city] = 0;
                }
            }
        }
nextProv = nextProvince(isConnected);
            }
        
        return provinces;
    }

    public int nextProvince(int[][] cities){
        for (int i =0 ; i< cities.Length;i++){
            if(cities[i][i] == 1)return i;
        }
        return -1;
    }
}
