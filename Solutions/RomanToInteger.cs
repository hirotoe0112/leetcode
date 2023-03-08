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
    
    /*
    https://leetcode.com/problems/roman-to-integer/solutions/1362651/c-runtime-94-and-memory-98-o-n/?orderBy=hot&languageTags=csharp
    */

    // 上のURLを参考に、Dictionaryをswitch文に変えたら速さは上がった。（でも実行する度に変化するような…）メモリも微妙に良くなったかもしれない？
    public int Run2(string s){
        var list = new string[]{
            "IV","IX","XL","XC","CD","CM","I","V","X","L","C","D","M"
        };
        var result = 0;
        foreach(var c in list){
            // 文字の出現回数を調べる
            // (元の文字の長さ - 置換後の文字の長さ) / 文字長
            var count = (s.Length - s.Replace(c, "").Length) / c.Length;

            // 数値 * 出現回数だけresultに加算する
            result += ValueFromChar(c) * count;

            // 出現済みの文字を削除する
            s = s.Replace(c, "");
        }
        return result;
    }

    private int ValueFromChar(string c){
        switch(c){
            case "IV": return 4;
            case "IX": return 9;
            case "XL": return 40;
            case "XC": return 90;
            case "CD": return 400;
            case "CM": return 900;
            case "I": return 1;
            case "V": return 5;
            case "X": return 10;
            case "L": return 50;
            case "C": return 100;
            case "D": return 500;
            case "M": return 1000;
            default: return 0;
        }
    }
}