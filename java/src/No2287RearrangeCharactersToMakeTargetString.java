/*
https://leetcode.com/problems/rearrange-characters-to-make-target-string/description/
*/
import java.util.HashMap;

public class No2287RearrangeCharactersToMakeTargetString {
  public static void main(String[] args) {
    // Input
    String s = "ilovecodingonleetcode";
    String target = "code";

    Solution solution = new Solution();
    System.out.println(solution.rearrangeCharacters(s, target));
  }
}

class Solution {
    public int rearrangeCharacters(String s, String target) {
      HashMap<Character, Integer> sMap = new HashMap<>();
      HashMap<Character, Integer> targetMap = new HashMap<>();

      for(int i = 0; i < s.length(); i++) {
        Character c = s.charAt(i);
        sMap.put(c, sMap.get(c) == null ? 1 : sMap.get(c) + 1);
      }
      for(int i = 0; i < target.length(); i++) {
        Character c = target.charAt(i);
        targetMap.put(c, targetMap.get(c) == null ? 1 : targetMap.get(c) + 1);
      }

      int result = -1;
      for(HashMap.Entry<Character, Integer> entry: targetMap.entrySet()) {
        int numOfResource = sMap.get(entry.getKey()) == null ? 0 : sMap.get(entry.getKey());
        int numOfTarget = entry.getValue();

        int usableCount = numOfResource / numOfTarget;
        if(result == -1) {
          result = usableCount;
        }else{
          result = Math.min(result, usableCount);
        }
      }

      return result;
    }
}