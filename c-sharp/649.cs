//
// 649. Dota2 Senate
//

public class Solution {
    // Let 'n' be the length of the string 'senate'
    // Time:    O(n)
    // Space:   O(n)
    public string PredictPartyVictory(string senate) {
        // Track the number of senators in each party
        int r = 0;
        int d = 0;

        // Track the number of senators who have been banned by the opposing party
        int bannedR = 0;
        int bannedD = 0;

        // Enqueue all senators and determine their counts
        Queue<char> q = new Queue<char>();
        foreach (char senator in senate) {
            if (senator == 'R') {
                r++;
            }
            else {
                d++;
            }
            q.Enqueue(senator);
        }

        while (q.Count > 1 && r > 0 && d > 0) {
            char senator = q.Dequeue();

            // Radiant senator
            if (senator == 'R') {
                // Skip this senator and adjust the variables accordingly
                if (bannedR > 0) {
                    r--;
                    bannedR--;
                    continue;
                }
                // Ban an opposing senator and enqueue the senator again
                else {
                    bannedD++;
                    q.Enqueue(senator);
                }
            }
            // Dire senator
            else {
                if (bannedD > 0) {
                    d--;
                    bannedD--;
                    continue;
                }
                else {
                    bannedR++;
                    q.Enqueue(senator);
                }
            }
        }

        // Queue will consist only of senators from the victious party
        return (q.Dequeue() == 'R' ? "Radiant" : "Dire");
    }
}
