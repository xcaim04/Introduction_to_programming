import java.util.HashMap;

class Ej1 {

    HashMap<Character, Integer> romanNumbers = new HashMap<Character, Integer>();

    public void initHashMap() {

        romanNumbers.put('I', 1);
        romanNumbers.put('V', 5);
        romanNumbers.put('X', 10);
        romanNumbers.put('L', 50);
        romanNumbers.put('C', 100);
        romanNumbers.put('D', 500);
        romanNumbers.put('M', 1000);
    }

    public int romanToInt(String s) {

        Ej1 obj = new Ej1();
        obj.initHashMap();
        int ans = 0;

        for(int i=0;i<s.length();) {
            
            int curr = obj.romanNumbers.get(s.charAt(i));
            int suc = 0;
            if(i+1 < s.length())
                suc = obj.romanNumbers.get(s.charAt(i+1));

            if(curr < suc) {
                ans += (suc - curr);
                i+=2;
            }

            else {
                ans += curr;
                i++;
            }
        

        }

        return ans;

    }

    public static void main(String[] args) {
        Ej1 ans = new Ej1();
        System.out.println(ans.romanToInt("MCMXCIV"));
    }
}