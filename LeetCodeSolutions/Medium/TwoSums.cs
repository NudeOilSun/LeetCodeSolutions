namespace LeetCodeSolutions.Medium;

public class TwoSums
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
     * Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
 */
    
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
         }
 }
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int formatedNodel1 = FormatListNode(l1);
            int formatedNodel2 = FormatListNode(l2);
            
            int sumOfNodes = formatedNodel1 + formatedNodel2;

            // edge case
            if (sumOfNodes == 0) return new ListNode(0);
            
            //Puts the Sum back into ListNodesObject
            ListNode dummy = new ListNode(0); 
            ListNode current = dummy;
    
            while (sumOfNodes > 0)
            {
                int digit = sumOfNodes % 10;
                current.next = new ListNode(digit);  
                current = current.next;              
                sumOfNodes /= 10;
            }

            return dummy.next;
        }
        
        private int FormatListNode(ListNode node)
        {
            //Go through the nodes and extract each value
            ListNode currentL1 = node;
            List<int> l1Values = new List<int>();

            while (currentL1 != null)
            {
                l1Values.Add(currentL1.val);
                currentL1 = currentL1.next;
            }

            //reverse the order
            l1Values.Reverse();
            int result = 0;

            //turn the value of ints into a whole number
            foreach (int d in l1Values)
            {
                result = result * 10 + d;
            }
            
            return result;
        }
    }
}