/*
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
*/


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
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head =  new ListNode();
        
        ListNode final = head;
        while(list1 !=null && list2 !=null){
            if(list1.val <=list2.val){
                final.next = list1;
                list1 = list1.next;
            }
            else{
                final.next = list2;
                list2 = list2.next;
            }
            final = final.next;
        }
        
        final.next = list1 == null? list2:list1;
        return head.next;
    }
}
