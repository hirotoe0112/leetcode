public class TwoSum{
    public int[] Run(int[] nums, int target){
        var answer = new int[2];
        var done = false;
        for(var i = 0; i < nums.Length - 1; i++){
            var currentNum = nums[i];
            for(var j = 1; j < nums.Length; j++){
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
}