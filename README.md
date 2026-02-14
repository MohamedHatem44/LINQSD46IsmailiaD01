# LINQSD46IsmailiaD01

# 🔷 LINQ Deep Dive – Before & After LINQ (.NET 9)

This repository contains two .NET 9 console applications that demonstrate the evolution 
from traditional filtering approaches to modern LINQ (Language Integrated Query) implementation in C#:

- ✅ Manual filtering (Before LINQ)
- ✅ Delegates & Extension Methods
- ✅ LINQ (Method Syntax & Query Syntax)
- ✅ Single Element Operators
- ✅ Anonymous Types & Functions
- ✅ IEnumerable vs ICollection

Built using **.NET 9 Console Applications**

---

# 📁 Solution Structure

```
LINQ-Solution
│
├── BeforeLINQ        → Manual Filtering & Custom Extension Methods
└── LINQD01           → Full LINQ Demonstrations
```

---

# 🚀 Project 1: BeforeLINQ

This project explains how developers filtered data **before LINQ existed**.

## 1️⃣ V01 – Hardcoded Filtering

Each method filters manually using `foreach`.

```csharp
public static List<Employee> GetEmployeesWithNameStartWith(string val)
```

### Problems:
- ❌ Code duplication  
- ❌ Not reusable  
- ❌ Tight coupling with Repository  

---

## 2️⃣ V02 – Using Predicate Delegate

Generic filtering using:

```csharp
Predicate<Employee>
```

```csharp
public static List<Employee> FilterEmployees(
    IEnumerable<Employee> employees,
    Predicate<Employee> predicate)
```

### Improvements:
- ✔ More reusable  
- ✔ Better separation of concerns  

---

## 3️⃣ V03 – Extension Method

Converted filtering into an extension method:

```csharp
public static List<Employee> FilterEmployees(
   this IEnumerable<Employee> employees,
   Predicate<Employee> predicate)
```

### Usage:

```csharp
var result = employees.FilterEmployees(e => e.Age > 25);
```

### Benefits:
- ✔ Cleaner syntax  
- ✔ More readable  
- ✔ Similar to LINQ behavior  

---

# 🚀 Project 2: LINQD01

This project demonstrates real **LINQ features**.

---

# 📌 What is LINQ?

> LINQ stands for **Language Integrated Query**  
It provides a unified way to query data from different sources using C# syntax.

```csharp
using System.Linq;
```

All LINQ methods exist inside:

```csharp
Enumerable (Static Class)
```

---

# 📚 LINQ Syntax Types

## 1️⃣ Method Syntax (Fluent API)

```csharp
var result = employees
    .Where(e => e.Age > 25)
    .OrderBy(e => e.Name)
    .ToList();
```

✔ Supports all LINQ methods (~40 methods)  
✔ Uses Lambda Expressions  
✔ Most commonly used  

---

## 2️⃣ Query Syntax (SQL-like)

```csharp
var result =
    from e in employees
    where e.Age > 25
    orderby e.Name descending
    select e;
```

✔ Easier for SQL developers  
❌ Limited (around 12 operations only)

---

# 📌 Common LINQ Operations

## 🔎 Filtering

```csharp
Where()
```

## 📊 Sorting

```csharp
OrderBy()
OrderByDescending()
ThenBy()
ThenByDescending()
```

---

# 📌 Single Element Operators

| Method                | If No Match                           | If Multiple Matches                |
|-----------------------|---------------------------------------|------------------------------------|
| `First()`             | Throws Exception                      | Returns first matching element     |
| `FirstOrDefault()`    | Returns default (`null` / `0`)        | Returns first matching element     |
| `Last()`              | Throws Exception                      | Returns last matching element      |
| `LastOrDefault()`     | Returns default (`null` / `0`)        | Returns last matching element      |
| `Single()`            | Throws Exception                      | Throws Exception                   |
| `SingleOrDefault()`   | Returns default (`null` / `0`)        | Throws Exception                   |
| `ElementAt()`         | Throws Exception (index out of range) | —                                  |
| `ElementAtOrDefault()`| Returns default (`null` / `0`)        | —                                  |

---

# 📌 Delegates Explained

## Predicate<T>
- Returns `bool`
- Takes 1 parameter

```csharp
Predicate<Employee> p = e => e.Age > 25;
```

---

## Action<T>
- Returns `void`
- 0–16 parameters

---

## Func<T>
- Returns value
- 0–16 parameters

```csharp
Func<int, int> square = x => x * x;
```

---

# 📌 Anonymous Concepts

## Anonymous Object

```csharp
var obj = new { Id = 1, Name = "Ahmed" };
```

✔ No explicit class  
✔ Read-only properties  

---

## Anonymous Function (Lambda)

```csharp
(x, y) => x + y
```

---

> LINQ always returns `IEnumerable<T>` unless converted using `ToList()` or `ToArray()`.

---

# 📌 Example: Before vs LINQ

## ❌ Before LINQ

```csharp
foreach (var item in ints)
{
    if(item % 2 == 0)
    {
        res.Add(item);
    }
}
```

## ✅ With LINQ

```csharp
var result = ints.Where(x => x % 2 == 0).ToList();
```

✔ Cleaner  
✔ Shorter  
✔ More readable  

---

# 🎯 Learning Goals

This solution helps understand:

- How LINQ works internally  
- Why extension methods are powerful  
- Delegates & Lambda expressions  
- Deferred execution  
- Query chaining  
- Exception behavior of Single/First/Last  
- Clean code evolution  

---

# 🛠 Requirements

- .NET 9 SDK  
- Visual Studio 2022+  

---

# ▶ How to Run

```bash
dotnet run
```

Or open the solution in Visual Studio and press **F5**

---

# 📌 Key Takeaway

LINQ is essentially:

- Extension Methods  
- Delegates  
- Lambda Expressions  
- IEnumerable  

Combined together to create powerful, readable queries.

# 👨‍💻 Author

Mohamed Hatem  
Software Engineer  

---
