namespace evenOddNumbers;

public class Program{
    public static void Main(){
        Console.WriteLine("===== Even & Odd numbers =====");

        Console.WriteLine("Input a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number % 2 == 0){
            Console.WriteLine($"{number} is Even number");
        } else {
            Console.WriteLine($"{number} is Odd number");
        }
    }
}