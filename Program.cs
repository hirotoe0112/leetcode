// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 問題名=クラス名、実行用メソッド=Runで統一する
var instance = new TwoSum();
var result = instance.Run3(new int[]{3,3}, 6);
Console.WriteLine(string.Join(",", result));