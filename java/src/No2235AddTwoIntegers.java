/*
https://leetcode.com/problems/add-two-integers/description/
*/
public class No2235AddTwoIntegers {
    public static void main(String[] args) {
        // Parse the command line arguments
        int num1 = Integer.parseInt(args[0]);
        int num2 = Integer.parseInt(args[1]);

        Solution solution = new Solution();
        System.out.println(solution.sum(num1, num2));
    }
}

class Solution {
    public int sum(int num1, int num2) {
      return num1 + num2;
    }
}