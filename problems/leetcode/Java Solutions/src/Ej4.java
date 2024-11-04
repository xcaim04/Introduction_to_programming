import java.util.Stack;

public class Ej4 {
    
    public boolean isValid(String s) {
        Stack<Character> a = new Stack<Character>();

        for(char item: s.toCharArray()) {
            if(item == '(' || item == '{' || item == '[')
                a.push(item);
            else {
                if(a.empty()) return false;
                char top = a.peek();
                if((item == ')' && top != '(') || (item == '}' && top !='{') || (item == '[' && top != '}'))
                    return false;
                else a.pop();
            }
        }

        return true;

    }

    public static void main(String[] args) {
        Ej4 test = new Ej4();

        System.out.println(test.isValid("()"));
        System.out.println(test.isValid("[)"));
        System.out.println(test.isValid("()[]{}"));
    }

}
