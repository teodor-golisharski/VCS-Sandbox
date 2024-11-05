import java.util.*;

public class SoftUniReception {

    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        int first_num = Integer.parseInt(scanner.nextLine());
        int second_num = Integer.parseInt(scanner.nextLine());
        int third_num = Integer.parseInt(scanner.nextLine());

        int sum = Integer.parseInt(scanner.nextLine());
        int time_needed = 0;
        while(sum > 0)
        {
            sum-=(first_num+second_num+third_num);
            time_needed++;
        }
        int additional = (time_needed-1)/3;

        System.out.printf("Time needed: %sh.%n", time_needed+additional);
    }
}
