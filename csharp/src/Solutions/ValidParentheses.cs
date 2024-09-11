public class ValidParentheses
{
    List<string> former = new List<string>() { "(", "{", "[" };
    List<string> latter = new List<string>() { ")", "}", "]" };
    Dictionary<string, string> dict = new Dictionary<string, string>(){
        {"(", ")"},
        {"{", "}"},
        {"[", "]"},
    };
    public bool Run(string s)
    {
        // 偶数でなければfalse
        if (s.Length % 2 != 0) return false;

        var result = true;
        var newS = "";
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i].ToString();
            newS += c;

            // formerで終わっていたらNG
            if (former.Contains(c) && i == s.Length - 1)
            {
                result = false;
                break;
            }
            if (former.Contains(c)) continue;

            //latterで始まっていたらNG
            if (latter.Contains(c) && newS.Length == 1)
            {
                result = false;
                break;
            }

            // latterの場合は1つ前の文字がペアの文字ならOK
            var index = latter.IndexOf(c);
            if (newS[newS.Length - 2].ToString() != former[index])
            {
                result = false;
                break;
            }
            else
            {
                newS = newS.Substring(0, newS.Length - 2);
            }
        }
        // ペアは消去されていくので、最終的に残ったらNG
        if (newS.Length != 0) result = false;
        return result;
    }

    /*
    この発想はマジでなかった。
    https://leetcode.com/problems/valid-parentheses/solutions/3360331/easy-solution-with-replace/
    */
    public bool Run2(string s)
    {
        while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
        {
            s = s.Replace("()", "").Replace("{}", "").Replace("[]", "");
        }
        return s.Length == 0;
    }
}