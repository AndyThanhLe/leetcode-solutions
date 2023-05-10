// 
// 59. Spiral Matrix II
// 

public class Solution {
    // Time:    O(n^2)
    // Space:   O(n^2)
    public int[][] GenerateMatrix(int n) {
        // Declare and initialize variables denoting the section of the matrix we need to populate
        int x1 = 0;
        int x2 = n-1;
        int y1 = 0;
        int y2 = n-1;

        // Declare and initialize the matrix
        int[][] mat = new int[n][];
        for (int i = 0; i < n; i++) {
            mat[i] = new int[n];
        }

        int num = 1;                    // Variable to track the current number from 1 to n^2
        int max = (int)Math.Pow(n, 2);  // Greatest number in the spiral order
        int direction = 0;              // 0 : Right; 1 : Down; 2 : Left; 3 : Up
        while (num <= max) {
            // Right
            if (direction == 0) {
                // Iterate over indices we need to populate
                for (int i = x1; i <= x2; i++) {
                    mat[y1][i] = num++;
                }
                // Update 'border'
                y1++;
            }
            // Down
            else if (direction == 1) {
                for (int i = y1; i <= y2; i++) {
                    mat[i][x2] = num++;
                }
                x2--;
            }
            // Left
            else if (direction == 2) {
                for (int i = x2; i >= x1; i--) {
                    mat[y2][i] = num++;
                }
                y2--;
            }
            // Up
            else if (direction == 3) {
                for (int i = y2; i >= y1; i--) {
                    mat[i][x1] = num++;
                }
                x1++;
            }
            // Update direction
            direction = (direction + 1) % 4;
        }

        return mat;
    }
}