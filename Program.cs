// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 問題名=クラス名、実行用メソッド=Runで統一する
var instance = new ValidParentheses();
var result = instance.Run("{[");
if(result.GetType() == typeof(Array)){
    // 答えが配列用
    Console.WriteLine(string.Join(",", result));
    return;
}
Console.WriteLine(result);