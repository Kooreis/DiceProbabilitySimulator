```java
import java.util.Random;
import java.util.Scanner;

public class DiceProbabilitySimulator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();
        int[] diceCount = new int[13];

        System.out.println("Enter the number of dice rolls: ");
        int rolls = scanner.nextInt();

        for (int i = 0; i < rolls; i++) {
            int dice1 = random.nextInt(6) + 1;
            int dice2 = random.nextInt(6) + 1;
            diceCount[dice1 + dice2]++;
        }

        System.out.println("Results: ");
        for (int i = 2; i <= 12; i++) {
            System.out.println(i + ": " + diceCount[i] + " times, " + (double) diceCount[i] / rolls * 100 + "%");
        }
    }
}
```