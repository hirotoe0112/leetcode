/*
https://leetcode.com/problems/the-employee-that-worked-on-the-longest-task/description/
*/
public class No2432TheEmployeeThatWorkedOnTheLongestTask {
  public static void main(String[] args) {
    // Input
    int n = 10;
    int[][] logs = {{0, 3}, {2, 5}, {0, 9}, {1, 15}};

    Solution solution = new Solution();
    System.out.println(solution.hardestWorker(n, logs));
  }
}

class Solution {
    public int hardestWorker(int n, int[][] logs) {
      int[] longest = logs[0];
      for (int i = 1; i < logs.length; i++) {
        int[] current = logs[i];
        int[] previous = logs[i - 1];
        int id = current[0];
        int duration = current[1] - previous[1];
        if (longest[1] < duration) {
          longest = new int[]{id, duration};
        } else if (longest[1] == duration && id < longest[0]) {
          longest = new int[]{id, duration};
        }
      }
      return longest[0];
    }
}