public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
    
        int width = maze.Length - 1;
        var first = maze[0];
        int height= first.Length - 1;
        Queue<int[]> rooms =new Queue<int[]>();
        rooms.Enqueue([entrance[0],entrance[1],0]);
    maze[entrance[0]][entrance[1]] = '+';
        while (rooms.Count > 0){
            var room = rooms.Dequeue();
            var x = room[0];
            var y = room[1];
            var count = room[2];
            if ((x ==0 || y == 0 || x == width || y == height) && count>0) return count;
            count++;
            if (x> 0 && maze[x-1][y] == '.') {rooms.Enqueue([x-1,y,count ]); maze[x-1][y] = '+';}
           if (x < width&& maze[x+1][y] == '.') {rooms.Enqueue([x+1,y,count]); maze[x+1][y]= '+';}
           if (y > 0 && maze[x][y-1] == '.') {rooms.Enqueue([x,y-1,count]);maze[x][y-1] = '+';}
           if (y < height&& maze[x][y+1] == '.') {rooms.Enqueue([x,y+1,count]); maze[x][y+1] = '+';}
        }

        return -1;
    }
}
