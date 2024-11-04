import java.util.ArrayList;
import java.util.Collections;

public class Ej2 {

    public boolean isPalindrome(int x) {

        if(x < 0) return false;

        ArrayList<Integer> arr = new ArrayList<Integer>();
        ArrayList<Integer> arr2 = new ArrayList<Integer>();

        while(x >= 10) {
            arr.add(x % 10);
            arr2.add(x % 10);
            x/=10;
        }

        arr.add(x);
        arr2.add(x);
        Collections.reverse(arr);

        return arr.equals(arr2);
    }

    public static void main(String[] args) {
        Ej2 sol = new Ej2();
        System.out.println(sol.isPalindrome(121));
        System.out.println(sol.isPalindrome(-121));
        System.out.println(sol.isPalindrome(10));
    }
}
