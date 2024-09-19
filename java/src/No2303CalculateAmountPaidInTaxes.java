/*
https://leetcode.com/problems/calculate-amount-paid-in-taxes/description/
*/
public class No2303CalculateAmountPaidInTaxes {
  public static void main(String[] args) {
    // Input
    int[][] brackets = {{3,50},{7,10},{12,25}};
    int income = 10;

    Solution solution = new Solution();
    System.out.println(solution.calculateTax(brackets, income));
  }
}

class Solution {
    public double calculateTax(int[][] brackets, int income) {
      int dealt = 0;
      double tax = 0;
      for (int i = 0; i < brackets.length; i++) {
        int currentTaxRate =brackets[i][1];
        int taxableIncome = brackets[i][0] - dealt;
        int remainingIncome = income - dealt;

        if (remainingIncome < taxableIncome) {
          tax += remainingIncome * currentTaxRate / 100.0;
          break;
        } else {
          tax += taxableIncome * currentTaxRate / 100.0;
        }

        dealt = brackets[i][0];
      }
      return tax;
    }
}