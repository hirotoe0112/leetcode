/*
https://leetcode.com/problems/uncommon-words-from-two-sentences/description/
*/
import java.util.HashMap;
import java.util.ArrayList;
import java.util.Arrays;

public class No884UncommonWordsFromTwoSentences {
  public static void main(String[] args) {
    // Input
    String s1 = "apple apple";
    String s2 = "banana";

    Solution solution = new Solution();
    System.out.println(solution.uncommonFromSentences(s1, s2));
  }
}

class Solution {
  public String[] uncommonFromSentences(String s1, String s2) {
    HashMap<String, Integer> map = new HashMap<>();
    ArrayList<String> allWords = new ArrayList<String>();
    allWords.addAll(Arrays.asList(s1.split(" ")));
    allWords.addAll(Arrays.asList(s2.split(" ")));

    ArrayList<String> result = new ArrayList<String>();

    for (int i = 0; i < allWords.size(); i++) {
      String word = allWords.get(i);
      if (map.containsKey(word)) {
        map.put(word, 2);
      } else {
        map.putIfAbsent(word, 1);
      }
    }
    for (HashMap.Entry<String, Integer> entry: map.entrySet()){
      if (entry.getValue() == 1) {
        result.add(entry.getKey());
      }
    }

    return result.toArray(new String[result.size()]);
  }
}