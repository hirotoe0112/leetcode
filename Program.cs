// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 問題名=クラス名、実行用メソッド=Runで統一する
var instance = new MergeTwoSortedLists();
//var result = instance.Run(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));
var result = instance.Run(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));
if(result.GetType() == typeof(Array)){
    // 答えが配列用
    Console.WriteLine(string.Join(",", result));
    return;
}
Console.WriteLine(result);