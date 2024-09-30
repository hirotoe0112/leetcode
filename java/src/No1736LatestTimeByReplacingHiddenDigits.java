/*
https://leetcode.com/problems/latest-time-by-replacing-hidden-digits/description/
*/
public class No1736LatestTimeByReplacingHiddenDigits {
  public static void main(String[] args) {
    // Input
    String time = "2?:?0";

    Solution solution = new Solution();
    System.out.println(solution.maximumTime(time));
  }
}

class Solution {
    public String maximumTime(String time) {
      StringBuilder sb = new StringBuilder(time);
      char h10 = sb.charAt(0);
      char h1 = sb.charAt(1);
      char m10 = sb.charAt(3);
      char m1 = sb.charAt(4);

      // hour
      if (h10 == '?') {
        if (h1 == '?') {
          sb.setCharAt(0, '2');
          sb.setCharAt(1, '3');
        } else if (h1 < '4') {
          sb.setCharAt(0, '2');
        } else {
          sb.setCharAt(0, '1');
        }
      } else if (h10 == '2') {
        if (h1 == '?') {
          sb.setCharAt(0, '2');
          sb.setCharAt(1, '3');
        }
      } else {
        if (h1 == '?') {
          sb.setCharAt(1, '9');
        }
      }

      // minute
      if (m10 == '?') {
        if (m1 == '?') {
          sb.setCharAt(3, '5');
          sb.setCharAt(4, '9');
        } else {
          sb.setCharAt(3, '5');
        }
      } else {
        if (m1 == '?') {
          sb.setCharAt(4, '9');
        }
      }

      return sb.toString();
    }

    public String maximumTime_org(String time) {
      String h10 = String.valueOf(time.charAt(0));
      String h1 = String.valueOf(time.charAt(1));
      String m10 = String.valueOf(time.charAt(3));
      String m1 = String.valueOf(time.charAt(4));

      String h, m = "";

      // hour
      if (h10.equals("?")) {
        if (h1.equals("?")) {
          h = "23";
        } else if (Integer.parseInt(h1) < 4) {
          h = "2" + h1;
        } else {
          h = "1" + h1;
        }
      } else if (h10.equals("2")) {
        if (h1.equals("?")) {
          h = "23";
        } else {
          h = h10 + h1;
        }
      } else {
        if (h1.equals("?")) {
          h = h10 + "9";
        } else {
          h = h10 + h1;
        }
      }

      // minute
      if (m10.equals("?")) {
        if (m1.equals("?")) {
          m = "59";
        } else {
          m = "5" + m1;
        }
      } else {
        if (m1.equals("?")) {
          m = m10 + "9";
        } else {
          m = m10 + m1;
        }
      }

      return h + ":" + m;
    }
}