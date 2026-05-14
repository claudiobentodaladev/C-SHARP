# C# Fundamentals — A Complete Mini Course

A ground-up introduction to the C# programming language covering every core concept you need before diving into ASP.NET Core. Each section includes working code examples and clear explanations.

---

## Table of Contents

1. [What Is C# and How It Works](#1-what-is-c-and-how-it-works)
2. [Setting Up Your Environment](#2-setting-up-your-environment)
3. [Program Structure](#3-program-structure)
4. [Variables and Data Types](#4-variables-and-data-types)
5. [Type Conversion and Casting](#5-type-conversion-and-casting)
6. [Operators](#6-operators)
7. [String Manipulation](#7-string-manipulation)
8. [Control Flow](#8-control-flow)
9. [Loops](#9-loops)
10. [Arrays](#10-arrays)
11. [Collections](#11-collections)
12. [Methods](#12-methods)
13. [Object-Oriented Programming](#13-object-oriented-programming)
14. [Inheritance](#14-inheritance)
15. [Interfaces](#15-interfaces)
16. [Abstract Classes](#16-abstract-classes)
17. [Enums](#17-enums)
18. [Structs](#18-structs)
19. [Exception Handling](#19-exception-handling)
20. [Generics](#20-generics)
21. [Delegates and Events](#21-delegates-and-events)
22. [Lambda Expressions](#22-lambda-expressions)
23. [LINQ](#23-linq)
24. [Nullable Types](#24-nullable-types)
25. [Records](#25-records)
26. [File I/O](#26-file-io)
27. [Asynchronous Programming](#27-asynchronous-programming)
28. [Namespaces and Using Directives](#28-namespaces-and-using-directives)
29. [Access Modifiers](#29-access-modifiers)
30. [What Comes Next — ASP.NET Core](#30-what-comes-next--aspnet-core)

---

## 1. What Is C# and How It Works

C# (pronounced "C sharp") is a statically typed, object-oriented language developed by Microsoft. It runs on the **.NET runtime (CLR — Common Language Runtime)**, which means your source code is first compiled into an intermediate language (IL/bytecode), and then the CLR compiles it to native machine code at runtime using a JIT (Just-In-Time) compiler.

Key characteristics:

- **Strongly typed** — every variable has a fixed type known at compile time.
- **Object-oriented** — built around classes and objects.
- **Managed memory** — the Garbage Collector (GC) handles memory deallocation.
- **Cross-platform** — .NET 6+ runs on Windows, Linux, and macOS.
- **Versatile** — used for web (ASP.NET Core), desktop (WPF, MAUI), games (Unity), CLI tools, and more.

---

## 2. Setting Up Your Environment

**Requirements:**

- Install the [.NET SDK](https://dotnet.microsoft.com/download) (version 8 recommended).
- Use [Visual Studio](https://visualstudio.microsoft.com/) (Windows/Mac) or [VS Code](https://code.visualstudio.com/) with the C# Dev Kit extension.

**Creating and running a project:**

```bash
# Create a new console application
dotnet new console -n MyCourse

# Navigate into the project folder
cd MyCourse

# Run the project
dotnet run
```

---

## 3. Program Structure

A minimal C# program using **top-level statements** (introduced in C# 9):

```csharp
// Program.cs
Console.WriteLine("Hello, World!");
```

The traditional, explicit structure (still valid and used in class libraries):

```csharp
using System;

namespace MyCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

**Key points:**

- `using System;` imports the `System` namespace so you can use `Console` without its full path.
- `namespace` groups related code to avoid name collisions.
- `Main` is the application entry point.
- Statements end with a semicolon `;`.
- C# is case-sensitive.

---

## 4. Variables and Data Types

### Value Types (stored on the stack)

```csharp
// Integer types
byte   a = 255;          // 0 to 255
short  b = 32000;        // -32,768 to 32,767
int    c = 2_000_000;    // most common integer type
long   d = 9_000_000_000L;

// Floating-point types
float  e = 3.14f;        // 7 digits of precision (suffix f required)
double f = 3.14159265;   // 15–17 digits of precision (default for decimals)
decimal g = 19.99m;      // 28–29 digits — use for money (suffix m required)

// Other value types
bool   h = true;
char   i = 'A';          // Single Unicode character, single quotes
```

### Reference Types (stored on the heap)

```csharp
string  name    = "Claudio";   // Immutable sequence of characters
object  obj     = 42;          // Base type of every type in C#
int[]   numbers = { 1, 2, 3 }; // Array
```

### var — Implicit Typing

The compiler infers the type from the right-hand side. The type is still fixed at compile time.

```csharp
var age     = 21;          // inferred as int
var pi      = 3.14;        // inferred as double
var message = "Hello";     // inferred as string
```

### Constants and Read-only

```csharp
const double Pi = 3.14159;      // compile-time constant, never changes
readonly int maxAttempts = 5;   // set once, either at declaration or in a constructor
```

---

## 5. Type Conversion and Casting

### Implicit Conversion (safe, no data loss)

```csharp
int    x = 100;
long   y = x;     // int fits inside long, no cast needed
double z = x;     // same idea
```

### Explicit Casting (you accept potential data loss)

```csharp
double pi    = 3.99;
int    whole = (int)pi;   // whole = 3, decimal part is truncated
```

### Convert Class and Parse

```csharp
string input = "42";

int    parsed   = int.Parse(input);          // throws if input is invalid
bool   success  = int.TryParse(input, out int result); // safe version, no exception

int    converted = Convert.ToInt32("100");
string asString  = Convert.ToString(42);
```

### ToString

```csharp
int    number = 255;
string hex    = number.ToString("X");   // "FF" (hexadecimal)
string padded = number.ToString("D6");  // "000255"
```

---

## 6. Operators

### Arithmetic

```csharp
int a = 10, b = 3;

Console.WriteLine(a + b);   // 13
Console.WriteLine(a - b);   // 7
Console.WriteLine(a * b);   // 30
Console.WriteLine(a / b);   // 3  (integer division, truncates)
Console.WriteLine(a % b);   // 1  (remainder/modulo)
```

### Comparison

```csharp
Console.WriteLine(5 == 5);   // True
Console.WriteLine(5 != 3);   // True
Console.WriteLine(5 >  3);   // True
Console.WriteLine(5 <  3);   // False
Console.WriteLine(5 >= 5);   // True
Console.WriteLine(5 <= 4);   // False
```

### Logical

```csharp
bool t = true, f = false;

Console.WriteLine(t && f);   // False (AND)
Console.WriteLine(t || f);   // True  (OR)
Console.WriteLine(!t);       // False (NOT)
```

### Assignment Shorthands

```csharp
int x = 10;
x += 5;   // x = 15
x -= 3;   // x = 12
x *= 2;   // x = 24
x /= 4;   // x = 6
x %= 4;   // x = 2
x++;      // x = 3 (post-increment)
++x;      // x = 4 (pre-increment)
```

### Ternary Operator

```csharp
int age = 20;
string status = age >= 18 ? "Adult" : "Minor";
```

### Null-Coalescing Operators

```csharp
string? name = null;

string display = name ?? "Anonymous";         // "Anonymous" if name is null
name ??= "Default";                           // assign only if null
```

---

## 7. String Manipulation

Strings in C# are **immutable** reference types. Every operation that "changes" a string actually creates a new one.

```csharp
string first = "Claudio";
string last  = "Bento";

// Concatenation
string full = first + " " + last;

// String interpolation (preferred)
string greeting = $"Hello, {first} {last}!";

// Common string methods
Console.WriteLine(full.Length);                    // character count
Console.WriteLine(full.ToUpper());                 // "CLAUDIO BENTO"
Console.WriteLine(full.ToLower());                 // "claudio bento"
Console.WriteLine(full.Contains("Bento"));         // True
Console.WriteLine(full.StartsWith("Cl"));          // True
Console.WriteLine(full.Replace("Bento", "Silva")); // "Claudio Silva"
Console.WriteLine(full.Trim());                    // removes leading/trailing spaces
Console.WriteLine(full.Substring(0, 7));           // "Claudio"
Console.WriteLine(full.IndexOf("Bento"));          // 8

// Split and Join
string csv    = "a,b,c,d";
string[] parts = csv.Split(',');                   // ["a", "b", "c", "d"]
string joined = string.Join(" - ", parts);         // "a - b - c - d"

// Verbatim strings (raw path, no escaping needed)
string path = @"C:\Users\Claudio\Documents";

// Multi-line raw string literals (C# 11)
string json = """
    {
        "name": "Claudio",
        "lang": "ENIDE"
    }
    """;
```

### StringBuilder (for many concatenations)

When you need to build a string through many operations, use `StringBuilder` to avoid creating dozens of intermediate strings.

```csharp
using System.Text;

var sb = new StringBuilder();
sb.Append("Hello");
sb.Append(", ");
sb.Append("World");
sb.AppendLine("!");
sb.Insert(0, ">>> ");

string result = sb.ToString(); // ">>> Hello, World!\n"
```

---

## 8. Control Flow

### if / else if / else

```csharp
int score = 75;

if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 75)
{
    Console.WriteLine("B");
}
else if (score >= 60)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("F");
}
```

### switch Statement

```csharp
string day = "Monday";

switch (day)
{
    case "Saturday":
    case "Sunday":
        Console.WriteLine("Weekend");
        break;
    case "Monday":
        Console.WriteLine("Back to work");
        break;
    default:
        Console.WriteLine("Weekday");
        break;
}
```

### switch Expression (C# 8+, concise and returns a value)

```csharp
int month = 4;

string season = month switch
{
    12 or 1 or 2 => "Winter",
    3  or 4 or 5 => "Spring",
    6  or 7 or 8 => "Summer",
    9  or 10 or 11 => "Autumn",
    _ => "Unknown"
};
```

### Pattern Matching

```csharp
object shape = 3.14;

if (shape is double d && d > 2.0)
{
    Console.WriteLine($"Large double: {d}");
}

// Type patterns in switch
string Describe(object obj) => obj switch
{
    int i    => $"Integer: {i}",
    string s => $"String of length {s.Length}",
    null     => "Null value",
    _        => "Something else"
};
```

---

## 9. Loops

### for

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // 0, 1, 2, 3, 4
}
```

### while

```csharp
int count = 0;

while (count < 3)
{
    Console.WriteLine(count);
    count++;
}
```

### do / while (runs at least once)

```csharp
int n = 0;

do
{
    Console.WriteLine(n);
    n++;
}
while (n < 3);
```

### foreach

```csharp
string[] languages = { "C#", "ENIDE", "Python" };

foreach (string lang in languages)
{
    Console.WriteLine(lang);
}
```

### Loop Control

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 3) continue;  // skip iteration 3
    if (i == 7) break;     // exit the loop at 7
    Console.WriteLine(i);  // prints 0, 1, 2, 4, 5, 6
}
```

---

## 10. Arrays

Arrays have a **fixed size** set at creation time.

```csharp
// Declaration and initialization
int[] scores = new int[5];          // five zeros
int[] primes = { 2, 3, 5, 7, 11 }; // inline initialization

// Access by index (zero-based)
primes[0] = 2;
Console.WriteLine(primes[4]);      // 11

// Length
Console.WriteLine(primes.Length);  // 5

// Iterating
for (int i = 0; i < primes.Length; i++)
{
    Console.WriteLine(primes[i]);
}

// Multi-dimensional array
int[,] matrix = new int[3, 3];
matrix[0, 0]  = 1;
matrix[1, 1]  = 5;
matrix[2, 2]  = 9;

// Jagged array (array of arrays, each row can have a different length)
int[][] jagged = new int[3][];
jagged[0] = new int[] { 1, 2 };
jagged[1] = new int[] { 3, 4, 5 };
jagged[2] = new int[] { 6 };

// Useful Array methods
int[] nums = { 5, 1, 3, 2, 4 };
Array.Sort(nums);                  // { 1, 2, 3, 4, 5 }
Array.Reverse(nums);               // { 5, 4, 3, 2, 1 }
int idx = Array.IndexOf(nums, 3);  // finds the index of value 3
```

---

## 11. Collections

Unlike arrays, most collections in `System.Collections.Generic` resize dynamically.

### List\<T\>

```csharp
using System.Collections.Generic;

var fruits = new List<string> { "apple", "banana", "cherry" };

fruits.Add("date");
fruits.Remove("banana");
fruits.Insert(1, "blueberry");

Console.WriteLine(fruits.Count);         // 3
Console.WriteLine(fruits.Contains("date")); // True

fruits.Sort();
fruits.Reverse();

foreach (var fruit in fruits)
    Console.WriteLine(fruit);
```

### Dictionary\<TKey, TValue\>

```csharp
var capitals = new Dictionary<string, string>
{
    { "Angola",  "Luanda" },
    { "France",  "Paris"  },
    { "Germany", "Berlin" }
};

capitals["Japan"] = "Tokyo"; // add or update

if (capitals.TryGetValue("Angola", out string capital))
    Console.WriteLine(capital); // "Luanda"

foreach (var pair in capitals)
    Console.WriteLine($"{pair.Key}: {pair.Value}");
```

### HashSet\<T\> (unique values, fast lookup)

```csharp
var set = new HashSet<int> { 1, 2, 3, 3, 2 };
// set contains { 1, 2, 3 } — duplicates ignored

set.Add(4);
set.Remove(1);
Console.WriteLine(set.Contains(2)); // True
```

### Queue\<T\> and Stack\<T\>

```csharp
// Queue: first-in, first-out
var queue = new Queue<string>();
queue.Enqueue("first");
queue.Enqueue("second");
string item = queue.Dequeue(); // "first"

// Stack: last-in, first-out
var stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
int top = stack.Pop(); // 20
```

---

## 12. Methods

### Basic Method

```csharp
static int Add(int a, int b)
{
    return a + b;
}

Console.WriteLine(Add(3, 4)); // 7
```

### Expression-bodied Method (one-liner)

```csharp
static int Multiply(int a, int b) => a * b;
```

### Optional Parameters and Named Arguments

```csharp
static string Greet(string name, string greeting = "Hello")
{
    return $"{greeting}, {name}!";
}

Console.WriteLine(Greet("Claudio"));              // "Hello, Claudio!"
Console.WriteLine(Greet("Claudio", "Welcome"));   // "Welcome, Claudio!"
Console.WriteLine(Greet(greeting: "Hi", name: "Claudio")); // named args
```

### ref and out Parameters

```csharp
// ref: pass variable by reference (must be initialized before)
static void Double(ref int value) => value *= 2;

int x = 5;
Double(ref x);
Console.WriteLine(x); // 10

// out: return multiple values (does not need prior initialization)
static bool TryDivide(int a, int b, out double result)
{
    if (b == 0) { result = 0; return false; }
    result = (double)a / b;
    return true;
}

if (TryDivide(10, 3, out double r))
    Console.WriteLine(r); // 3.333...
```

### params — Variable Number of Arguments

```csharp
static int Sum(params int[] numbers)
{
    int total = 0;
    foreach (var n in numbers) total += n;
    return total;
}

Console.WriteLine(Sum(1, 2, 3));         // 6
Console.WriteLine(Sum(1, 2, 3, 4, 5));  // 15
```

### Method Overloading

```csharp
static double Area(double radius)         => Math.PI * radius * radius;
static double Area(double width, double height) => width * height;

Console.WriteLine(Area(5));       // circle
Console.WriteLine(Area(4, 6));    // rectangle
```

---

## 13. Object-Oriented Programming

### Classes and Objects

```csharp
class Person
{
    // Fields
    private string _name;
    private int    _age;

    // Constructor
    public Person(string name, int age)
    {
        _name = name;
        _age  = age;
    }

    // Properties
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            _age = value;
        }
    }

    // Auto-implemented property (compiler generates the backing field)
    public string Email { get; set; } = string.Empty;

    // Method
    public string Introduce() => $"Hi, I am {_name} and I am {_age} years old.";

    // Static method (belongs to the class, not an instance)
    public static string Species() => "Homo sapiens";

    // Override ToString for meaningful output
    public override string ToString() => $"Person({_name}, {_age})";
}

// Usage
var person = new Person("Claudio", 17);
person.Email = "claudio@example.com";
Console.WriteLine(person.Introduce());
Console.WriteLine(Person.Species());
Console.WriteLine(person);
```

### Object Initializer Syntax

```csharp
var person2 = new Person("Ana", 22)
{
    Email = "ana@example.com"
};
```

### this Keyword

```csharp
class Counter
{
    private int _count = 0;

    public Counter Increment()
    {
        _count++;
        return this; // allows method chaining
    }

    public Counter Reset() { _count = 0; return this; }

    public int Value => _count;
}

var c = new Counter();
int value = c.Increment().Increment().Increment().Value; // 3
```

---

## 14. Inheritance

```csharp
class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual string Speak() => "...";

    public override string ToString() => $"{GetType().Name}({Name})";
}

class Dog : Animal
{
    public string Breed { get; }

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }

    public override string Speak() => "Woof!";
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override string Speak() => "Meow!";
}

// Polymorphism: treat different types through a shared base type
Animal[] animals = { new Dog("Rex", "Labrador"), new Cat("Whiskers") };

foreach (var animal in animals)
    Console.WriteLine($"{animal.Name} says: {animal.Speak()}");
```

### Sealed Class and Sealed Method

```csharp
// sealed class: cannot be inherited
sealed class FinalClass { }

// sealed override: prevents further overriding down the hierarchy
class SpecialDog : Dog
{
    public SpecialDog(string name) : base(name, "Mixed") { }
    public sealed override string Speak() => "Woof woof!";
}
```

### Casting and Type Checking

```csharp
Animal animal = new Dog("Buddy", "Poodle");

// is operator (check type)
if (animal is Dog dog)
    Console.WriteLine(dog.Breed);

// as operator (returns null if cast fails, no exception)
Dog? maybeDog = animal as Dog;
if (maybeDog is not null)
    Console.WriteLine(maybeDog.Breed);
```

---

## 15. Interfaces

An interface defines a **contract** — a set of members that an implementing class must provide. Interfaces contain no state (fields) and no implementation by default.

```csharp
interface IShape
{
    double Area();
    double Perimeter();
    string Description => $"Area: {Area():F2}, Perimeter: {Perimeter():F2}"; // default implementation (C# 8+)
}

interface IDrawable
{
    void Draw();
}

class Circle : IShape, IDrawable
{
    public double Radius { get; }

    public Circle(double radius) { Radius = radius; }

    public double Area()      => Math.PI * Radius * Radius;
    public double Perimeter() => 2 * Math.PI * Radius;
    public void   Draw()      => Console.WriteLine($"Drawing circle with radius {Radius}");
}

class Rectangle : IShape, IDrawable
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width  = width;
        Height = height;
    }

    public double Area()      => Width * Height;
    public double Perimeter() => 2 * (Width + Height);
    public void   Draw()      => Console.WriteLine($"Drawing rectangle {Width}x{Height}");
}

// Usage through the interface type (polymorphism)
IShape[] shapes = { new Circle(5), new Rectangle(4, 6) };

foreach (var shape in shapes)
    Console.WriteLine(shape.Description);
```

---

## 16. Abstract Classes

An abstract class sits between a concrete class and an interface. It can contain both abstract members (no body, must be overridden) and concrete members (with implementation).

```csharp
abstract class Vehicle
{
    public string Brand   { get; }
    public int    Year    { get; }

    protected Vehicle(string brand, int year)
    {
        Brand = brand;
        Year  = year;
    }

    // Must be implemented by subclasses
    public abstract double FuelEfficiency();

    // Shared concrete behavior
    public void PrintInfo()
    {
        Console.WriteLine($"{Year} {Brand} — {FuelEfficiency():F1} km/L");
    }
}

class Car : Vehicle
{
    private double _efficiency;

    public Car(string brand, int year, double efficiency) : base(brand, year)
    {
        _efficiency = efficiency;
    }

    public override double FuelEfficiency() => _efficiency;
}

class ElectricCar : Vehicle
{
    public ElectricCar(string brand, int year) : base(brand, year) { }

    public override double FuelEfficiency() => double.PositiveInfinity; // no fuel
}

var cars = new Vehicle[]
{
    new Car("Toyota", 2020, 14.5),
    new ElectricCar("Tesla", 2023)
};

foreach (var v in cars)
    v.PrintInfo();
```

---

## 17. Enums

Enums define a named set of constant integer values.

```csharp
enum Direction { North, South, East, West }

enum HttpStatus
{
    OK          = 200,
    Created     = 201,
    BadRequest  = 400,
    Unauthorized = 401,
    NotFound    = 404,
    ServerError = 500
}

// [Flags] allows bitwise combination of values
[Flags]
enum Permissions
{
    None    = 0,
    Read    = 1,
    Write   = 2,
    Execute = 4,
    All     = Read | Write | Execute
}

// Usage
Direction dir    = Direction.North;
HttpStatus status = HttpStatus.OK;

Console.WriteLine(dir);                           // "North"
Console.WriteLine((int)status);                   // 200
Console.WriteLine(status == HttpStatus.OK);       // True

Permissions userPerms = Permissions.Read | Permissions.Write;
Console.WriteLine(userPerms.HasFlag(Permissions.Read));  // True
Console.WriteLine(userPerms.HasFlag(Permissions.Execute)); // False

// Parse from string
Direction parsed = Enum.Parse<Direction>("East");

// All values
foreach (Direction d in Enum.GetValues<Direction>())
    Console.WriteLine(d);
```

---

## 18. Structs

Structs are value types (stored on the stack) — suitable for small, immutable data bundles like coordinates or colors.

```csharp
struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Point other)
    {
        double dx = X - other.X;
        double dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public override string ToString() => $"({X}, {Y})";
}

var a = new Point(0, 0);
var b = new Point(3, 4);
Console.WriteLine(a.DistanceTo(b)); // 5.0

// Structs are copied on assignment — a and c are independent
var c = a;
```

Key differences between struct and class:

| Feature          | struct (value type) | class (reference type) |
|------------------|---------------------|------------------------|
| Storage          | Stack               | Heap                   |
| Assignment       | Copies value        | Copies reference       |
| Default value    | Zero/empty          | null                   |
| Inheritance      | Cannot inherit      | Can inherit            |
| null allowed     | No (unless Nullable)| Yes                    |

---

## 19. Exception Handling

```csharp
// try / catch / finally
try
{
    int[] arr = new int[3];
    arr[10] = 99; // throws IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Index error: {ex.Message}");
}
catch (Exception ex) // catch any other exception
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
finally
{
    // Always runs, regardless of exception — used for cleanup
    Console.WriteLine("Done.");
}

// Throwing exceptions
static int Divide(int a, int b)
{
    if (b == 0)
        throw new DivideByZeroException("Divisor cannot be zero.");
    return a / b;
}

// Custom exception
class InvalidAgeException : Exception
{
    public int Age { get; }

    public InvalidAgeException(int age)
        : base($"Age {age} is not valid.")
    {
        Age = age;
    }
}

static void SetAge(int age)
{
    if (age < 0 || age > 150)
        throw new InvalidAgeException(age);
}

try
{
    SetAge(-5);
}
catch (InvalidAgeException ex)
{
    Console.WriteLine(ex.Message); // "Age -5 is not valid."
    Console.WriteLine(ex.Age);     // -5
}

// when filter
try
{
    Divide(10, 0);
}
catch (DivideByZeroException ex) when (ex.Message.Contains("zero"))
{
    Console.WriteLine("Caught specifically: divisor was zero.");
}
```

---

## 20. Generics

Generics let you write type-safe code that works with any type, decided at compile time.

```csharp
// Generic method
static T Max<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) >= 0 ? a : b;
}

Console.WriteLine(Max(3, 7));       // 7
Console.WriteLine(Max("apple", "banana")); // "banana"

// Generic class
class Stack<T>
{
    private readonly List<T> _items = new();

    public void Push(T item) => _items.Add(item);

    public T Pop()
    {
        if (_items.Count == 0) throw new InvalidOperationException("Stack is empty.");
        var top = _items[^1];
        _items.RemoveAt(_items.Count - 1);
        return top;
    }

    public T Peek() => _items.Count > 0 ? _items[^1]
        : throw new InvalidOperationException("Stack is empty.");

    public int Count => _items.Count;
}

var intStack = new Stack<int>();
intStack.Push(1);
intStack.Push(2);
intStack.Push(3);
Console.WriteLine(intStack.Pop()); // 3

// Generic constraints
// where T : class        — T must be a reference type
// where T : struct       — T must be a value type
// where T : new()        — T must have a parameterless constructor
// where T : SomeClass    — T must inherit from SomeClass
// where T : ISomeInterface — T must implement ISomeInterface
```

---

## 21. Delegates and Events

### Delegates

A delegate is a type-safe function pointer — it holds a reference to a method.

```csharp
// Declare a delegate type
delegate int MathOperation(int a, int b);

static int Add(int a, int b) => a + b;
static int Mul(int a, int b) => a * b;

MathOperation op = Add;
Console.WriteLine(op(3, 4));  // 7

op = Mul;
Console.WriteLine(op(3, 4));  // 12

// Multicast delegate (holds multiple methods)
Action<string> log = Console.WriteLine;
log += s => System.IO.File.AppendAllText("log.txt", s + "\n");
log("This goes to both console and file");

// Built-in delegate types
Func<int, int, int>  add = (a, b) => a + b;       // has return value
Action<string>       print = Console.WriteLine;     // void return
Predicate<int>       isEven = n => n % 2 == 0;     // returns bool
```

### Events

Events are a publisher-subscriber pattern built on delegates.

```csharp
class Button
{
    // Event declaration using EventHandler (standard pattern)
    public event EventHandler<string>? Clicked;

    public void Click()
    {
        Console.WriteLine("Button clicked.");
        Clicked?.Invoke(this, "ClickData"); // raise the event
    }
}

var btn = new Button();

// Subscribe to the event
btn.Clicked += (sender, data) => Console.WriteLine($"Handler 1 received: {data}");
btn.Clicked += (sender, data) => Console.WriteLine($"Handler 2 received: {data}");

btn.Click();
// Output:
// Button clicked.
// Handler 1 received: ClickData
// Handler 2 received: ClickData
```

---

## 22. Lambda Expressions

Lambdas are anonymous (unnamed) functions defined inline.

```csharp
// Syntax: (parameters) => expression
Func<int, int> square     = x => x * x;
Func<int, int, int> add   = (a, b) => a + b;

// Multi-statement lambda (uses a block body)
Func<int, string> describe = n =>
{
    if (n > 0) return "positive";
    if (n < 0) return "negative";
    return "zero";
};

Console.WriteLine(square(5));       // 25
Console.WriteLine(add(3, 4));       // 7
Console.WriteLine(describe(-3));    // "negative"

// Lambdas used inline with collection methods
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evens   = numbers.Where(n => n % 2 == 0);          // filter
var doubled = numbers.Select(n => n * 2);              // transform
var sum     = numbers.Aggregate((total, n) => total + n); // reduce
```

---

## 23. LINQ

**Language Integrated Query** allows you to query any collection using a SQL-like syntax or method chains.

```csharp
using System.Linq;

var students = new List<(string Name, int Score, string Grade)>
{
    ("Alice",  92, "A"),
    ("Bob",    73, "B"),
    ("Carol",  88, "A"),
    ("David",  55, "C"),
    ("Eve",    95, "A"),
};

// --- Method syntax (most common) ---

// Filter
var gradeA = students.Where(s => s.Grade == "A");

// Transform
var names = students.Select(s => s.Name);

// Sort
var sorted = students.OrderByDescending(s => s.Score);

// Take / Skip (pagination)
var top3 = students.OrderByDescending(s => s.Score).Take(3);

// Aggregate
int    totalScore   = students.Sum(s => s.Score);
double averageScore = students.Average(s => s.Score);
int    highestScore = students.Max(s => s.Score);

// First / Single / Any / All
var topStudent  = students.First(s => s.Score == students.Max(s2 => s2.Score));
bool anyFailing = students.Any(s => s.Score < 60);
bool allPassed  = students.All(s => s.Score >= 50);

// GroupBy
var byGrade = students.GroupBy(s => s.Grade);
foreach (var group in byGrade)
{
    Console.WriteLine($"Grade {group.Key}: {string.Join(", ", group.Select(s => s.Name))}");
}

// --- Query syntax (SQL-style) ---

var queryResult =
    from s in students
    where s.Score >= 75
    orderby s.Score descending
    select new { s.Name, s.Score };

foreach (var item in queryResult)
    Console.WriteLine($"{item.Name}: {item.Score}");
```

---

## 24. Nullable Types

### Nullable Value Types

```csharp
int? age = null;  // int? is shorthand for Nullable<int>

if (age.HasValue)
    Console.WriteLine(age.Value);
else
    Console.WriteLine("Age unknown");

int result = age ?? 0; // use 0 if null
```

### Nullable Reference Types (C# 8+)

Enable in your project file with `<Nullable>enable</Nullable>` in the `.csproj`. Once enabled, reference types are non-nullable by default. You must explicitly mark them with `?` to allow null.

```csharp
string  name  = "Claudio"; // cannot be null — compiler warns
string? alias = null;       // explicitly nullable

// Null-conditional operator
int? length = alias?.Length; // null if alias is null, no NullReferenceException

// Null-forgiving operator (tells compiler "trust me, not null here")
string forced = alias!; // suppress warning — use with caution
```

---

## 25. Records

Records are immutable reference types designed for data-carrying objects. They auto-generate equality, `ToString`, and a deconstructor.

```csharp
// Positional record (concise)
record Point(double X, double Y);

// Record with extra methods
record Person(string Name, int Age)
{
    public string Greeting => $"Hello, I am {Name}.";
}

var p1 = new Point(1.0, 2.0);
var p2 = new Point(1.0, 2.0);
var p3 = new Point(3.0, 4.0);

Console.WriteLine(p1 == p2);   // True (value-based equality)
Console.WriteLine(p1 == p3);   // False
Console.WriteLine(p1);         // "Point { X = 1, Y = 2 }"

// with-expression: create a copy with some properties changed
var p4 = p1 with { Y = 99.0 }; // p1 is unchanged, p4 = (1, 99)

// Deconstruct
var (x, y) = p1;
Console.WriteLine($"x={x}, y={y}");

// record struct (value type record, C# 10+)
record struct Color(byte R, byte G, byte B);
```

---

## 26. File I/O

```csharp
using System.IO;

string filePath = "data.txt";

// Write all text (creates or overwrites)
File.WriteAllText(filePath, "Hello, ENIDE!\nLine two.\n");

// Append text
File.AppendAllText(filePath, "Appended line.\n");

// Read all text
string content = File.ReadAllText(filePath);
Console.WriteLine(content);

// Read all lines into an array
string[] lines = File.ReadAllLines(filePath);
foreach (var line in lines)
    Console.WriteLine(line);

// Write lines from a collection
File.WriteAllLines(filePath, new[] { "A", "B", "C" });

// Check existence
if (File.Exists(filePath))
    Console.WriteLine("File exists.");

// StreamWriter / StreamReader (for large files — streaming, not loading all at once)
using var writer = new StreamWriter(filePath, append: true);
writer.WriteLine("Written with StreamWriter.");

using var reader = new StreamReader(filePath);
while (!reader.EndOfStream)
{
    string? line = reader.ReadLine();
    Console.WriteLine(line);
}

// Path manipulation
string dir      = Path.GetDirectoryName(filePath) ?? ".";
string fileName = Path.GetFileNameWithoutExtension(filePath); // "data"
string ext      = Path.GetExtension(filePath);                // ".txt"
string fullPath = Path.GetFullPath(filePath);
string combined = Path.Combine("folder", "subfolder", "file.txt");

// Directory operations
Directory.CreateDirectory("mydir");
string[] files = Directory.GetFiles(".", "*.txt");
```

---

## 27. Asynchronous Programming

C# uses `async` / `await` to write non-blocking code that remains readable. It is essential for I/O-bound operations like web requests and file reads.

```csharp
using System.Net.Http;

// async method must return Task (void), Task<T> (with value), or ValueTask<T>
static async Task<string> FetchPageAsync(string url)
{
    using var client = new HttpClient();
    string content = await client.GetStringAsync(url); // non-blocking wait
    return content;
}

static async Task ProcessFilesAsync()
{
    // Async file I/O
    string text = await File.ReadAllTextAsync("data.txt");
    await File.WriteAllTextAsync("output.txt", text.ToUpper());
}

// Run multiple tasks in parallel
static async Task RunParallelAsync()
{
    Task<string> t1 = FetchPageAsync("https://example.com");
    Task<string> t2 = FetchPageAsync("https://microsoft.com");

    // Await both at the same time
    string[] results = await Task.WhenAll(t1, t2);
    Console.WriteLine($"Fetched {results.Length} pages.");
}

// Entry point can be async in modern C#
static async Task Main()
{
    await ProcessFilesAsync();
    await RunParallelAsync();
}

// CancellationToken — cooperative cancellation
static async Task LongOperationAsync(CancellationToken token)
{
    for (int i = 0; i < 100; i++)
    {
        token.ThrowIfCancellationRequested();
        await Task.Delay(50, token);
        Console.WriteLine($"Step {i}");
    }
}

var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
try
{
    await LongOperationAsync(cts.Token);
}
catch (OperationCanceledException)
{
    Console.WriteLine("Operation was cancelled.");
}
```

---

## 28. Namespaces and Using Directives

```csharp
// Declaring a namespace
namespace MyApp.Models
{
    class User
    {
        public string Username { get; set; } = string.Empty;
    }
}

// File-scoped namespace (C# 10+, applies to the entire file — no extra braces)
namespace MyApp.Services;

class AuthService
{
    public bool Validate(string token) => token.Length > 10;
}

// Using directives
using System;                          // standard namespace
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyAlias = System.Text.StringBuilder; // alias

// Global using (C# 10+) — applies to the entire project, put in a single file
global using System;
global using System.Collections.Generic;

// Static using — import static members directly (no class prefix needed)
using static System.Math;
using static System.Console;

double area = PI * Pow(5, 2); // no need for Math.PI or Math.Pow
WriteLine(area);               // no need for Console.WriteLine
```

---

## 29. Access Modifiers

| Modifier             | Accessible from                                  |
|----------------------|--------------------------------------------------|
| `public`             | Anywhere                                         |
| `private`            | Only within the same class (default for members) |
| `protected`          | Same class and all derived classes               |
| `internal`           | Anywhere within the same assembly (.dll/.exe)    |
| `protected internal` | Same assembly OR derived classes                 |
| `private protected`  | Same class OR derived classes within the assembly|

```csharp
class BankAccount
{
    private   decimal _balance;          // only this class
    public    string  Owner { get; }     // anyone
    protected int     PinCode { get; }   // this class and subclasses
    internal  string  BranchCode { get; set; } = "001"; // same assembly

    public BankAccount(string owner, decimal initialBalance)
    {
        Owner    = owner;
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
        _balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > _balance) return false;
        _balance -= amount;
        return true;
    }

    public decimal Balance => _balance; // read-only public property
}
```

---

## 30. What Comes Next — ASP.NET Core

With the C# fundamentals from this guide you are ready to move into **ASP.NET Core**, Microsoft's cross-platform web framework. Here is a roadmap of what to study next:

**Minimal APIs and Controllers**

```csharp
var builder = WebApplication.CreateBuilder(args);
var app     = builder.Build();

app.MapGet("/hello", () => "Hello from ASP.NET Core!");
app.MapGet("/users/{id:int}", (int id) => new { Id = id, Name = "Claudio" });

app.Run();
```

**Recommended learning path after this guide:**

1. **Minimal APIs** — define HTTP endpoints with very little boilerplate.
2. **Dependency Injection** — ASP.NET Core has a built-in DI container; understanding interfaces (Chapter 15) is essential here.
3. **Middleware** — the request pipeline, how requests flow through layers.
4. **Entity Framework Core** — ORM for database access; LINQ (Chapter 23) is used heavily here.
5. **Controllers and MVC** — the classic Model-View-Controller pattern.
6. **Razor Pages / Blazor** — server-side and WebAssembly UI.
7. **Authentication and Authorization** — JWT, cookies, roles, policies.
8. **Configuration and Environments** — `appsettings.json`, environment variables.
9. **Logging** — `ILogger<T>` and structured logging.
10. **Testing** — xUnit, MSTest, integration tests with `WebApplicationFactory`.

Every concept in this guide — classes, interfaces, generics, async/await, LINQ — maps directly to daily ASP.NET Core work. You are well prepared.

---

## Quick Reference

```
Value types:   int, double, float, decimal, bool, char, byte, short, long, struct, enum
Reference types: string, object, class, interface, delegate, array, record
Type safety:   var (inferred), explicit casts, TryParse
OOP pillars:   Encapsulation (properties), Inheritance (:), Polymorphism (virtual/override), Abstraction (abstract/interface)
Async:         async Task, await, Task.WhenAll, CancellationToken
LINQ:          Where, Select, OrderBy, GroupBy, First, Any, All, Sum, Average
Null safety:   ?, ??, ??=, ?., !
Concise syntax: expression bodies (=>), switch expressions, pattern matching, records, top-level statements
```

---

*Written as a preparation guide for ASP.NET Core development. All examples target .NET 8 / C# 12.*