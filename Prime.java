package com.company;
import java.util.Scanner;
public class Prime {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print(">>> ");
        int limit = input.nextInt() + 1;
        boolean P = false;
        int primes = 1;
        System.out.println("Prime: 2");
        for (int i = 3;i < limit; i++){
            for(int f = 2; f < Math.ceil(Math.sqrt(i)) + 1; f++){
                P = false;
                if(i % f == 0) {
                    System.out.println("Composite: " + i);
                    P = true;
                    break;
                }
            }
            if (P != true){
                System.out.println("Prime: " + i);
                primes++;
            }
        }
        System.out.println(primes);
    }
}
