import java.util.*;

public class Solution {

    static boolean compare(String a, String b) {
        return a.equals(b);
    }

    static boolean compare(int a, int b) {
        return a == b;
    }

    static boolean compare(int[] a, int[] b) {
        if (a.length != b.length) return false;
        for (int i = 0; i < a.length; i++) {
            if (a[i] != b[i]) return false;
        }
        return true;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int T = Integer.parseInt(sc.nextLine().trim());

        for (int t = 0; t < T; t++) {
            int type = Integer.parseInt(sc.nextLine().trim());

            if (type == 1) {
                String a = sc.nextLine().trim();
                String b = sc.nextLine().trim();
                System.out.println(compare(a, b) ? "Same" : "Different");

            } else if (type == 2) {
                int a = Integer.parseInt(sc.nextLine().trim());
                int b = Integer.parseInt(sc.nextLine().trim());
                System.out.println(compare(a, b) ? "Same" : "Different");

            } else {
                String[] nm = sc.nextLine().trim().split(" ");
                int n = Integer.parseInt(nm[0]);
                int m = Integer.parseInt(nm[1]);

                int[] a = new int[n];
                int[] b = new int[m];

                String[] lineA = sc.nextLine().trim().split(" ");
                for (int i = 0; i < n; i++) a[i] = Integer.parseInt(lineA[i]);

                String[] lineB = sc.nextLine().trim().split(" ");
                for (int i = 0; i < m; i++) b[i] = Integer.parseInt(lineB[i]);

                System.out.println(compare(a, b) ? "Same" : "Different");
            }
        }

        sc.close();
    }
}
