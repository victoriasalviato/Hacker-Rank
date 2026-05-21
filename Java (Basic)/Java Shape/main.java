import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.util.Scanner;

class Shape {
    int length;
    int breadth;

    Shape(int length, int breadth) {
        this.length = length;
        this.breadth = breadth;
    }

    void area() {
        System.out.println(length + " " + breadth);
    }
}

class Rectangle extends Shape {
    Rectangle(int length, int breadth) {
        super(length, breadth);
    }

    @Override
    void area() {
        super.area();
        System.out.println(length * breadth);
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int length = sc.nextInt();
        int breadth = sc.nextInt();

        Rectangle rect = new Rectangle(length, breadth);
        rect.area();

        sc.close();
    }
}
