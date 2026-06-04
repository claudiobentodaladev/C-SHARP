namespace variable;

public class Program{
    public static void Main(){
        try{
            string name;
            int age;

            Console.WriteLine("Type your name:");
            name = Console.ReadLine();

            Console.WriteLine("Type your age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"I am {name} and i am {age} years old");
        } catch{
            Console.WriteLine("Incorrect Data type!");
        }
    }
}