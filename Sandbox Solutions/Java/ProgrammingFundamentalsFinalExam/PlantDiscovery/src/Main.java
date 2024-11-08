import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Map<String, Plant> plants = new HashMap<>();

        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split("<->");

            Plant plant = new Plant(input[0], Integer.parseInt(input[1]));

            if (!plants.containsKey(input[0])) {
                plants.put(input[0], plant);
            } else {
                plants.get(input[0]).rarity = Integer.parseInt(input[1]);
            }
        }

        String command = scanner.nextLine();
        while (!command.equals("Exhibition")) {
            String[] commandComponents = command.split(": ");

            switch (commandComponents[0]) {
                case "Rate": {
                    String plantName = commandComponents[1].split(" - ")[0];
                    int rating = Integer.parseInt(commandComponents[1].split(" - ")[1]);

                    if (!plants.containsKey(plantName)) {
                        System.out.println("error");
                    } else {
                        plants.get(plantName).ratings.add(rating);
                    }
                }
                break;
                case "Update": {
                    String plantName = commandComponents[1].split(" - ")[0];
                    int newRarity = Integer.parseInt(commandComponents[1].split(" - ")[1]);

                    if (!plants.containsKey(plantName)) {
                        System.out.println("error");
                    } else {
                        plants.get(plantName).rarity = newRarity;
                    }
                }
                break;
                case "Reset":
                    String plantName = commandComponents[1];

                    if (!plants.containsKey(plantName)) {
                        System.out.println("error");
                    } else {
                        plants.get(plantName).ratings.clear();
                    }
                    break;
            }

            command = scanner.nextLine();
        }
        System.out.println("Plants for the exhibition:");
        plants.forEach((key, plant) -> System.out.printf("- %s; Rarity: %d; Rating: %s%n", key, plant.rarity, String.format("%.2f", plant.getAverageRating())));
    }
}

class Plant {
    Plant(String name, int rarity) {
        this.name = name;
        this.rarity = rarity;
        this.ratings = new ArrayList<>();
    }

    String name;
    int rarity;
    ArrayList<Integer> ratings;

    double getAverageRating() {
        return ratings.stream().mapToInt(Integer::intValue).average().orElse(0.0);
    }
}