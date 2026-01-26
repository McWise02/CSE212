public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}


//Hypotheses: It ensures every opening symbol has a matching closing symbol and closed in the correct order. 

//Test1 : (a == 3 or (b == 5 and c == 6))
// Return True

//Test 2: (students]i].Grade > 80 and students[i].Grade < 90)
//Return False


