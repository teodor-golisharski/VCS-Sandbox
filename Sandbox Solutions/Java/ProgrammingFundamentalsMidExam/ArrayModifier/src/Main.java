import java.util.ArrayList;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {

    public static void swap_command(ArrayList<Integer> arrayList, int index1, int index2) {
        int temp = arrayList.get(index1);
        arrayList.set(index1, arrayList.get(index2));
        arrayList.set(index2, temp);
    }

    public static void multiply_command(ArrayList<Integer> arrayList, int index1, int index2) {
        arrayList.set(index1, arrayList.get(index1) * arrayList.get(index2));
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        ArrayList<Integer> numbers = new ArrayList<Integer>();

        String input_number = scanner.nextLine();
        String[] nums = input_number.split(" ");

        for (String num : nums){
            numbers.add(Integer.parseInt(num));
        }

        while (true) {
            String[] command = scanner.nextLine().split(" ");

            switch (command[0]) {
                case "swap": {
                    int index1 = Integer.parseInt(command[1]);
                    int index2 = Integer.parseInt(command[2]);

                    swap_command(numbers, index1, index2);
                }
                break;

                case "multiply":
                    int index1 = Integer.parseInt(command[1]);
                    int index2 = Integer.parseInt(command[2]);

                    multiply_command(numbers, index1, index2);
                    break;

                case "decrease":
                    for (int i = 0; i < numbers.size(); i++) {
                        numbers.set(i, numbers.get(i) - 1);
                    }
                    break;

                case "end":
                    System.out.println(numbers.stream()
                            .map(String::valueOf)
                            .collect(Collectors.joining(", ")));
                    return;
            }
        }
    }
}