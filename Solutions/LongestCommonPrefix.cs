public class LongestCommonPrefix{
    public string Run(string[] strs){
        var result = "";
        var isEnd = false;
        // strsの最初の文字列を基準にする
        for(var i = 0; i < strs[0].Length; i++){
            var currentChar = strs[0][i];
            Console.WriteLine(currentChar);
            foreach(var str in strs){
                Console.WriteLine(str.Length);
                Console.WriteLine(i);
                // 最初の文字列より長さが短い場合は終了
                if(str.Length <= i){
                    isEnd = true;
                    break;
                }
                if(str[i] != currentChar){
                    isEnd = true;
                    break; 
                }
            }
            if(isEnd) break;
            result += currentChar;
        }
        return result;
    }

    /*
    参考：https://leetcode.com/problems/longest-common-prefix/solutions/2972955/c-using-string-with-min-length/?orderBy=hot&languageTags=csharp
    */
    public string Run2(string[] strs){
        var result = "";
        var isEnd = false;
        var shortest = strs.Min(e => e.Length);
        // strsの一番短い文字列の長さだけ比較する
        for(var i = 0; i < shortest; i++){
            var currentChar = strs[0][i];
            foreach(var str in strs){
                if(str[i] != currentChar){
                    isEnd = true;
                    break; 
                }
            }
            if(isEnd) break;
            result += currentChar;
        }
        return result;
    }
}