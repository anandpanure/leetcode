/*Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
Example 1:

Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
Example 2:

Input: numRows = 1
Output: [[1]]
*/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> final = new List<IList<int>>();
        final.Add(new List<int>());
        final[0].Add(1);
        
        for(int row=1;row<numRows;row++){
            IList<int> currRow =  new List<int>();
            IList<int> prevRow = final[row-1];
            
            //first element of each row
            currRow.Add(1);
            
            for(int col=1;col<prevRow.Count;col++){
                currRow.Add(prevRow[col-1] + prevRow[col]);
            }
            
            //last element of each row
            currRow.Add(1);
            
            
            final.Add(currRow);
        }
        
        return final;
    }
}
