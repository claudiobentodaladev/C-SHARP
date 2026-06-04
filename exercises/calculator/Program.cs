namespace calculator;

public class Program{
    public static void Main(){
        try{
            Console.WriteLine("===== Calculator =====");
            
            Console.WriteLine("Input number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subtracion = number1 - number2;
            int multiplication = number1 * number2;
            double div = number1 / number2;

            Console.WriteLine("===== Calculator =====");

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Subtracion: {subtracion}");
            Console.WriteLine($"Multiplication: {multiplication}");
            Console.WriteLine($"Div: {div}");
        }
        catch{
            Console.WriteLine("Error in math operation!");
        }
    }
}