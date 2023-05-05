// 
// 1456. Maximum Number of Vowels in a Substring of Given Length
// 

public class Solution {
    // Let 'n' be the length of the string s
    // Time:    O(n) as we will iterate over the length of the string minus some constant k
    // Space:   O(1) as we just store the vowels
    public int MaxVowels(string s, int k) {
        // Declare and initialize HashSet to contain all vowels
        HashSet<char> vowels = new HashSet<char>();
        vowels.Add('a');
        vowels.Add('e');
        vowels.Add('i');
        vowels.Add('o');
        vowels.Add('u');

        // Declare and initialize variables
        int n = s.Length;
        int max = 0;
        int num = 0;    // Number of vowels in the current substring

        // Consider substring of length 'k' starting from index 0 of string 's'
        for (int i = 0; i < k; i++) {
            if (vowels.Contains(s[i])) {
                num++;
            }
        }

        // Initialize the 'max' variable
        max = num;

        // Consider substrings of length 'k' starting from index i of string 's'
        // We will only consider the first and last character of the substring and adjust the max accordingly
        for (int i = k; i < n; i++) {
            // Check if first character of the previous substring was a vowel
            if (vowels.Contains(s[i-k])) {
                if (num > 0) {
                    num--;
                }
            }

            // Check if last character of substring is a vowel
            if (vowels.Contains(s[i])) {
                num++;
            }

            // Update max if current substring has more recorded vowels
            if (num > max) {
                max = num;
            }
        }

        return max;
    }
}
