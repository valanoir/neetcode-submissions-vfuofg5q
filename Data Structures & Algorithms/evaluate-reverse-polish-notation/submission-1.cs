public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int result = 0;
        for(int i=0;i<tokens.Length;i++){
            if(int.TryParse(tokens[i], out int num)){
                stack.Push(num);
            }
            else{
                int val1 = stack.Pop();
                int val2 = stack.Pop();
                switch(tokens[i]){
                    case "+":
                    result = val2 + val1;
                    break;
                    case "-":
                    result = val2 - val1;
                    break;
                    case "*":
                    result = val2 * val1;
                    break;
                    case "/":
                    result = val2 / val1;
                    break;
                }
                stack.Push(result);
            }
        }
        return stack.Pop();
    }
}
