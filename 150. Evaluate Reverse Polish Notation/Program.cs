// See https://aka.ms/new-console-template for more information

using _150._Evaluate_Reverse_Polish_Notation;

string[] arr = ["10", "1", "1", "2", "+", "+", "+"];
var sol = new Solution();
int n = 100000;
while(n-- > 0)
    Console.WriteLine(sol.EvalRPN(["10", "1", "1", "2", "+", "+", "+"]));

    