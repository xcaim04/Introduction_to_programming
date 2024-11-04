import java.util.Arrays;

public class Ej3 {

    public String longestCommonPrefix(String[] a) {

        Arrays.sort(a);

        String first = a[0];
        String last = a[a.length-1];
        StringBuilder preffix = new StringBuilder();

        for(int i=0;i<first.length();i++) {
            if(first.charAt(i) != last.charAt(i)) {
                return preffix.toString();
            }
            preffix.append(first.charAt(i));
        }

        return preffix.toString();

    }

    public static void main(String[] args) {

        Ej3 test = new Ej3();
        String[] arr = new String[] { "", "b" };

        String ans = test.longestCommonPrefix(arr);
        System.out.println(ans);
    }
}
