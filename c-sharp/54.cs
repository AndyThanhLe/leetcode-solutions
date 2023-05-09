// 
// 54. Spiral Matrix
// 

public class Solution {
    // Time:    O(m x n)
    // Space:   O(m x n)
    public IList<int> SpiralOrder(int[][] matrix) {
        int direction = 0;
        // Direction legend
        // 0 : Right
        // 1 : Down
        // 2 : Left
        // 3 : Up
        
        List<int> elements = new List<int>();   // elements in their spiral order

        // Declare and intialize variables denoting the remaining part of the matrix to return
        int x1 = 0, x2 = matrix[0].Length-1;
        int y1 = 0, y2 = matrix.Length-1;

        while (x1 <= x2 && y1 <= y2) {
            // Add elements depending on the direction we are traversing
            // Increment the relevant variable to account for part of matrix that has been traversed
            if (direction == 0) {
                for (int i = x1; i <= x2; i++) {
                    elements.Add(matrix[y1][i]);
                }
                y1++;
            }
            else if (direction == 1) {
                for (int i = y1; i <= y2; i++) {
                    elements.Add(matrix[i][x2]);
                }
                x2--;
            }
            else if (direction == 2) {
                for (int i = x2; i >= x1; i--) {
                    elements.Add(matrix[y2][i]);
                }
                y2--;
            }
            else if (direction == 3) {
                for (int i = y2; i >= y1; i--) {
                    elements.Add(matrix[i][x1]);
                }
                x1++;
            }
            // Update direction
            direction = (direction + 1) % 4;
        }

        return elements;
    }
}
