import java.util.*;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .toList();

        double average = numbers.stream().mapToInt(Integer::intValue).average().orElse(0);

        List<Integer> greaterThanAverage = numbers.stream()
                .filter(num -> num > average)
                .sorted(Comparator.reverseOrder())
                .toList();

        if (greaterThanAverage.isEmpty()) {
            System.out.println("No");
        } else {
            greaterThanAverage.stream()
                    .limit(5)
                    .forEach(num -> System.out.print(num + " "));
        }
    }
}