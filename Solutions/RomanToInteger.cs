public class RomanToInteger{
    public int Run(string s){
        var dict = new Dictionary<string, int>(){
            {"IV", 4},
            {"IX", 9},
            {"XL", 40},
            {"XC", 90},
            {"CD", 400},
            {"CM", 900},
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000},
        };

        var result = 0;
        foreach(var pair in dict){
            // 文字の出現回数を調べる
            // (元の文字の長さ - 置換後の文字の長さ) / 文字長
            var count = (s.Length - s.Replace(pair.Key, "").Length) / pair.Key.Length;

            // 数値 * 出現回数だけresultに加算する
            result += pair.Value * count;

            // 出現済みの文字を削除する
            s = s.Replace(pair.Key, "");
        }
        return result;
    }
}