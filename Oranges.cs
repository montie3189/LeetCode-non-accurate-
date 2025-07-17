public class Solution {
    public int OrangesRotting(int[][] grid) {
        int height = grid.Length -1;
        var row1 = grid[0];
        int width = row1.Length -1;
        Queue<int[]> rotten = new Queue<int[]>();
       Queue<int[]> ripe = new Queue<int[]>();

        for(int i = 0;i < height+1; i++){
            var row = grid[i];
            for(int j = 0; j < width+1; j++){
                if(grid[i][j] == 1){
                    ripe.Enqueue([i,j]);
                }
                else if(grid[i][j] == 2){
                    rotten.Enqueue([i,j,0]);
                }
            }
        }
    
        var max= 0;
        if (ripe.Count == 0) return 0;
        while (rotten.Count > 0){
            var orange = rotten.Dequeue();
            var x = orange [0];
            var y = orange[1];
            var count = orange[2];
if (count > max) max = count;
        
            if (x > 0 && grid[x-1][y] == 1){
                grid[x-1][y] = 2;
                rotten.Enqueue([x-1,y,count+1]);
            }
        
           if (x <height&& grid[x+1][y] == 1){
                grid[x+1][y] = 2;
                rotten.Enqueue([x+1,y,count+1]);
            }
        
           if (y > 0 && grid[x][y-1] == 1){
                grid[x][y-1] = 2;
                rotten.Enqueue([x,y-1,count+1]);
            }
            
           if (y<width&& grid[x][y+1] == 1){
                grid[x][y+1] = 2;
                rotten.Enqueue([x,y+1,count+1]);
            }
            }

        foreach (int[] orange in ripe){
         
            if (grid[orange[0]][orange[1]] == 1) return -1;
        }

        return max;
        
    }
}
