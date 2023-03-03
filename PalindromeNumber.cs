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
        for(var i = 0; i <= checkLength; i++){
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
}
