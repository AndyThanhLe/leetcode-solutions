// 
// 71. Simplify Path
// 

public class Solution {
    // Let 'n' be the length of the path
    // Time:    O(n)
    // Space:   O(n)
    public string SimplifyPath(string path) {

        // Contains the directories
        Stack<string> st = new Stack<string>();

        int n = path.Length;

        for (int i = 0; i < n; i++) {
            if (path[i].Equals('/')) {
                continue;
            }

            int start = i;
            int end = i;
            
            while (end < n) {
                if (path[end].Equals('/')) {
                    break;
                }
                end++;
            }

            i = end;

            string sub = path.Substring(start, end-start);
            if (sub.Equals(".")) {
                // do nothing
            }
            else if (sub.Equals("..")) {
                if (st.Count > 0) {
                    st.Pop();
                }
            }
            else {
                st.Push(sub);
            }
        }

        if (st.Count == 0) {
            return "/";
        }

        Stack<string> st2 = new Stack<String>();
        while (st.Count > 0) {
            st2.Push(st.Pop());
        }

        StringBuilder sb = new StringBuilder();
        while (st2.Count > 0) {
            sb.Append("/" + st2.Pop());
        }

        return sb.ToString();
    }
}