public class PalindromeNumber{
    public bool Run(int x) {
        var chars = x.ToString().ToArray();
        Console.WriteLine($"chars={string.Join(",", chars)}");
        // 4桁の場合：4 / 2 = 2まで確認する
        // 0, 4-1-0
        // 1, 4-1-1
        // 5桁の場合：(5 + 1) / 2 = 3まで確認して
        // 0, 5-1-0
        // 1, 5-1-1
        // 2, 5-1-2 : このときi = x.length - 1 - i このときはチェックしない
        var checkLength = chars.Length % 2 == 0 ? chars.Length / 2 : chars.Length / 2 + 1;
        Console.WriteLine($"checkLength={checkLength}");
        // ここはi < checkLengthが正しいと思うけど=を外すと所要時間が増える。。。なぜ？
        //for(var i = 0; i <= checkLength; i++){
        for(var i = 0; i < checkLength; i++){
            // 比較するペアが存在しなくなった場合(数値の真ん中まできた場合)は終了
            if(i == chars.Length - 1 - i){
                return true;
            }
            if(chars[i] != chars[chars.Length - 1 - i]){
                return false;
            }
        }
        return true;
    }

    /*
    https://leetcode.com/problems/palindrome-number/solutions/3242162/c-java-python3-solutions-90-99-faster/?languageTags=csharp
    */
    

    /*
    https://leetcode.com/problems/palindrome-number/solutions/3188691/c-without-converting-to-string-simple-solution-92/?languageTags=csharp
    */
}
