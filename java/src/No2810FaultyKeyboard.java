/*
https://leetcode.com/problems/faulty-keyboard/
*/
public class No2810FaultyKeyboard {
  // Input
  String s = "string";

  Solution solution = new Solution();
  System.out.println(solution.finalString(s));
}

class Solution {
    /*
    StringBuilderを使えばO(1)になる
    O(2N) => O(N)
    */
    public String finalString(String s) {
      boolean isReverse = false;
      StringBuilder result = new StringBuilder();
      for(int i = 0; i < s.length(); i++) {
        if (s.charAt(i) == 'i') {
          isReverse = !isReverse;
          continue;
        }
        if (isReverse) {
          result.insert(0, s.charAt(i));
        } else {
          result.append(s.charAt(i));
        }
      }

      if(isReverse) {
        result = result.reverse();
      }

      return result.toString();
    }

    /*
    result = s.charAt(i) + result;部分がO(n)のためループ全体でO(n^2)となる
    */
    public String finalString_1(String s) {
      boolean isReverse = false;
      String result = "";
      for(int i = 0; i < s.length(); i++) {
        if (s.charAt(i) == 'i') {
          isReverse = !isReverse;
          continue;
        }
        if (isReverse) {
          result = s.charAt(i) + result;
        } else {
          result = result + s.charAt(i);
        }
      }

      if(isReverse) {
        result = new StringBuilder(result).reverse().toString();
      }

      return result;
    }
}