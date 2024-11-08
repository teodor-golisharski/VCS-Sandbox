import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {
    public static void main(String[] args) {
        String regexString = "=(?<name>[A-Z][A-Za-z]{2,})=|/(?<Name>[A-Z][A-Za-z]{2,})/";
        Pattern pattern = Pattern.compile(regexString);


        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        ArrayList<String> destinations = new ArrayList<>();

        Matcher matcher = pattern.matcher(input);
        while(matcher.find()){
            if (matcher.group("name") != null ) {
                destinations.add(matcher.group("name"));  // Adds the entire matched substring
            }
            if (matcher.group("Name") != null ) {
                destinations.add(matcher.group("Name"));  // Adds the entire matched substring
            }
        }

        int travelPoints = destinations.stream().mapToInt(String::length).sum();
        System.out.println("Destinations: " + String.join(", ", destinations));
        System.out.println("Travel Points: " + travelPoints);
    }
}