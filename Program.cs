// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 問題名=クラス名、実行用メソッド=Runで統一する
var instance = new LongestCommonPrefix();
var result = instance.Run(new string[]{"ab", "a"});
Console.WriteLine(result);
// 答えが配列用
//Console.WriteLine(string.Join(",", result));