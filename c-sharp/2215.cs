// 
// 2215. Find the Difference of Two Arrays
// 

public class Solution {
    // Time:    O( Max( nums1.Length, nums2.Length ) )
    // Space:   O( Max( nums1.Length, nums2.Length ) )
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        // Declare and initialize HashSet objects
        HashSet<int> hs1 = new HashSet<int>( nums1 );
        HashSet<int> hs2 = new HashSet<int>( nums2 );

        // 'same' HashSet will contain all the integers which are present in both arrays
        HashSet<int> same = new HashSet<int>( hs1 );
        same.IntersectWith(hs2);

        // Perform set difference on HashSet objects to remove all similar integers
        hs1.ExceptWith(same);
        hs2.ExceptWith(same);

        // Return lists in the requested output type
        List<IList<int>> l = new List<IList<int>>();

        List<int> l1 = new List<int>();
        foreach (int num in hs1) {
            l1.Add(num);
        }

        List<int> l2 = new List<int>();
        foreach (int num in hs2) {
            l2.Add(num);
        }

        l.Add(l1);
        l.Add(l2);

        return l;
    }
}
