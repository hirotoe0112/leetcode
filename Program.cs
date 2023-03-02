// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 問題名=クラス名、実行用メソッド=Runで統一する
var instance = new TwoSum();
var result = instance.Run(new int[]{3,1,1,1,2,1,1,4}, 6);
Console.WriteLine(string.Join(",", result));