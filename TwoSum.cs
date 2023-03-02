public class TwoSum{
    public int[] Run(int[] nums, int target){
        var answer = new int[2];
        var done = false;
        for(var i = 0; i < nums.Length - 1; i++){
            var currentNum = nums[i];
            for(var j = i + 1; j < nums.Length; j++){
                if(currentNum + nums[j] == target){
                    answer[0] = i;
                    answer[1] = j;
                    done = true;
                    break;
                }
            }
            if(done) break;
        }
        return answer;
    }

    /*
    https://leetcode.com/problems/two-sum/solutions/2909584/c-faster-than-99-87-simple-solution/
    配列が nums と呼ばれ、その配列内のインデックスが i と呼ばれるとしましょう。
    たとえば、nums[i] が数字の 10 で、ターゲットが 15 だとしましょう。
    既に 5 を見たことがある場合は、i と 5 を見つけた場所のインデックスが解であることがわかります。
    あとは、これまでに確認した数値とそれぞれのインデックスを追跡するだけです。
    ディクショナリはキーと値のペアを格納し、チェックは O(1) 時間しかかからないため、これはディクショナリを使用する絶好の機会です。

    各項目を調べながら、キーが nums[i] で値が i であるディクショナリにそれらを追加できます。
    つまり、キーは配列内の値であり、値は配列のインデックスです。

    前の例に戻り、配列のインデックス 3 に値 5 があったとします。
    ディクショナリには、キーが 5 で値が 3 の値が格納されている必要があります。
    値が 10 になったら、target - 10 = 5 を取得し、ディクショナリでその値を確認します。
    ディクショナリにはその値があるため、ディクショナリから i と値を返すことができます。
    */

    // マイナスもありうるのでこれはダメ
    public int[] Run2(int[] nums, int target){
        var answer = new int[2];
        for(var i = 0; i < nums.Length - 1; i++){
            var currentNum = nums[i];
            nums[i] = -1;
            if(currentNum >= target) break;
            Console.WriteLine($"CurrentNum={currentNum}");
            // ペアの値を決める
            var anotherNum = target - currentNum;
            Console.WriteLine($"Pair={anotherNum}");
            // ペアの値のインデックスを検索する
            var anotherNumIndex = Array.IndexOf(nums, anotherNum);
            Console.WriteLine($"AnotherIndex={anotherNumIndex}");
            Console.WriteLine($"i={i}");
            Console.WriteLine(anotherNumIndex != -1 && i != anotherNumIndex);
            if(anotherNumIndex != -1 && i != anotherNumIndex){
                answer[0] = i;
                answer[1] = anotherNumIndex;
                break;
            }
        }
        return answer;
    }
    // 模範解答
    public int[] Run3(int[] nums, int target){
        // Keyを値、Valueをインデックスとするディクショナリ
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(target-nums[i])){
                // 前に向かって検索するため、ペアの値は常に自分(i)より前にいる
                return new int[]{dict[target-nums[i]], i};
            }else{
                dict.Add(nums[i], i);
            }
        }
        return new int[2];
    }
}