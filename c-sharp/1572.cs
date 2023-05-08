// 
// 1572. Matrix Diagonal Sum
// 

public class Solution {
    // Let 'n' be the number of rows (or columns) in the matrix
    // Time:    O(n)
    // Space:   O(1)
    public int DiagonalSum(int[][] mat) {
        int n = mat.Length;

        int sum = 0;
        for (int i = 0; i < n; i++) {
            // Main diagonal entry
            sum += mat[i][i];
            // Secondary diagonal
            sum += mat[i][n-1-i];
        }

        // Adjust for the summation of the 'middle' element twice when there are an odd number of elements
        if (n % 2 == 1) {
            int mid = n / 2;
            sum -= mat[mid][mid];
        }

        return sum;
    }
}
