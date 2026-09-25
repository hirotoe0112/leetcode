/*
https://leetcode.com/problems/excel-sheet-column-number/
*/
public class No171ExcelSheetColumnNumber {
  public void main(String[] args) {
    // Input
    String s = "FXSHRXW";

    Solution solution = new Solution();
    System.out.println(solution.titleToNumber(s));
  }
}
class Solution {
    public int titleToNumber(String columnTitle) {
        String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int result = 0;

        for (int i = 0; i < columnTitle.length(); i++) {
          int exponent = columnTitle.length() - i - 1;
          char targetChar = columnTitle.charAt(i);
          int charNumber = chars.indexOf(targetChar) + 1;
          result += Math.pow(26, exponent) * charNumber;
        }

        return result;
    }
}