# Run C#

## 1. Create the project

Open your terminal and run:

```bash
dotnet new console -n NameProject
```

### What this does:

- **Creates a console-type project (CLI)**
- **Creates a folder** named `NameProject` with all the necessary files

---

## 2. Enter the project folder

```bash
cd NameProject
```

---

## 3. Project structure

List the files to see what was created:

```bash
ls
```

You will see something like:

```
NameProject.csproj
Program.cs
obj/
```

### Explanation:

- `Program.cs` → Your **main code** file
- `NameProject.csproj` → The **project configuration**
- `obj/` → **Internal files** (you can safely ignore these)

---

## 4. Edit the code

Open the project in your editor (e.g., VS Code):

```bash
code .
```

---

### Example code:

```csharp
Console.WriteLine("Hello, World!");
```

---

## 5. Build the project

```bash
dotnet build
```

If everything is correct, you’ll see:

```
Build succeeded.
```

---

## ▶ 6. Run the program

The simplest way to execute your code:

```bash
dotnet run
```

**Expected output:**

```
Hello, World!
```

---

## 7. Run the binary directly

After building, you can navigate to the generated output folder:

```bash
cd bin/Debug/net*
```

And run the executable directly:

```bash
./NameProject
```

---