namespace LINQD01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region Named Object
            //Student student = new Student()
            //{
            //    Id = 1,
            //    Name = "Mohamed",
            //    Age = 20
            //};

            //// Named Object => Object has reference name
            //student.Name = "Ahmed";
            //Console.WriteLine(student); // namspace.classname
            #endregion
            /*------------------------------------------------------------------*/
            #region Collection
            //// Base for all collection types
            //// 1- ICollection
            //// 2- IEnumerable
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            //IEnumerable<int> ints2 = new List<int>() { 1, 2, 3, 4, 5 }; // True
            ////IEnumerable<int> ints2 = new IEnumerable<int>() { 1, 2, 3, 4, 5 }; XX

            //// 1- LINQ Returns IEnumerable
            //// 2- EF 
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Object
            //// Anonymous Object => Object without reference name
            //List<Student> students = new List<Student>()
            //{
            //    new Student() { Id = 1, Name = "Mohamed", Age = 20 },
            //    new Student() { Id = 2, Name = "Ahmed", Age = 22 },
            //    new Student() { Id = 3, Name = "Sara", Age = 21 }
            //};

            //foreach (var item in students)
            //{ // Condition
            //    Console.WriteLine(item);
            //}

            //new Student(); // Object on the fly
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Function
            // Anonymous Function => Function without reference name
            // (int x, int y) => { return x + y; };
            // Func<int, int, int> func = (x, y) => { return x + y; };

            // Delegate
            // Built in - 3
            // 1- Predicate => Return Type bool and 1 only input parameter
            //Predicate<Student> predicate = s => s.Age > 20;

            // 2- Action => Return Type void and from 0 to 16 input parameters
            //Action action1 = () => Console.WriteLine("Hello");
            //Action<int, int> action2 = (x, y) => Console.WriteLine(x + y);

            // 3- Func => More Generic => return type Generic and from 0 to 16 input parameters
            //Func<int> func1 = () => { return 10; };
            //Func<int, int> func2 = x => x * x;
            //Func<string, string, int> func3 = (s1, s2) => s1.Length + s2.Length;
            #endregion
            /*------------------------------------------------------------------*/
            #region Anonymous Type
            //// var => LINQ
            //// var z;
            ////var x = 10;
            ////x = "Mohamed"; // XXXXXX
            //var s1 = new { SSN = 1, FullName = "Ahmed" };
            //Console.WriteLine(s1);
            //Console.WriteLine(s1.GetType());

            //// ReadOnly Object
            ////s1.FullName = "Mohamed";
            #endregion
            /*------------------------------------------------------------------*/
            #region Before LINQ
            //// Items / 2
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //List<int> res = new List<int>();
            //foreach (var item in ints)
            //{
            //    if(item % 2 == 0)
            //    {
            //        // Add To List
            //        res.Add(item);
            //    }
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region LINQ
            // Features Added on Collections
            // 40 Additional Methods (Extention Methods) System.linq
            // "LINQ stands for Language Integrated Query, a Microsoft .NET Framework
            // that provides a standardized way to query data from various data sources using
            // a common syntax within programming languages like C#"
            #endregion
            /*------------------------------------------------------------------*/
            #region Extension Method
            //string str = "Hello World from ITI";
            //int count1 = Helper.GetWordsCount(str);
            //Console.WriteLine(count1); // 4

            //int count2 = str.GetWordsCount();
            //Console.WriteLine(count2); // 4

            //int count3 = ExtentionMethod.GetWordsCount(str);
            //Console.WriteLine(count3); // 4
            #endregion
            /*------------------------------------------------------------------*/
            #region LINQ
            // 1- Query Syntax => SQL Like Syntax [Limited 12/40 Method]
            // 2- Method Syntax [Fluent API] => Lambda Expression Syntax [All 40 Methods]
            #endregion
            /*------------------------------------------------------------------*/
            #region Repository
            var employees = Repository.GetEmployees();
            var departments = Repository.GetDepartments();
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------");
            //foreach (var item in departments)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Method Syntax [Fluent API] Function Chaining
            //// namespace System.Linq
            //// Enumerable => Static Class that contains all LINQ Methods as Static Methods
            //// All Employess Depratem with = 1
            //var q1 = employees.Where(e => e.DeptId == 1);
            //var q2 = Enumerable.Where(employees, e => e.DeptId == 1);

            //var q3 = employees // 10
            //    .Where(e => e.Age > 25); // 4

            //IEnumerable<Employee> q4 = employees.Where(e => e.Salary > 5000);

            //List<Employee> q5 = employees.Where(e => e.Age > 30).ToList();

            //var q6 = employees              // 10
            //    .Where(e => e.Age > 25)     // 4
            //    .Where(e => e.DeptId == 3); // 2

            //var q7 = employees
            //    .Where(e => e.Age > 25 && e.DeptId == 3);

            //var q8 = employees
            //    .Where(e => e.Age > 25);

            //var q9 = employees            // 10 
            //    .Where(e => e.Age > 25)   // 6
            //    .OrderBy(e => e.Name);    // 6

            //var q10 = employees            // 10 
            //    .Where(e => e.Age > 25)   // 6
            //    .OrderByDescending(e => e.Name);    // 6

            //var q11 = employees           // 10 
            //    .Where(e => e.Age > 25)   // 6
            //    .OrderBy(e => e.Salary)   // 6
            //    .OrderBy(e => e.Name);    // 6 XXXXXX

            //var q12 = employees           // 10 
            //    .Where(e => e.Age > 25)   // 6
            //    .OrderBy(e => e.Salary)   // 6
            //    .ThenBy(e => e.Name);    // 6 

            //foreach (var item in q10)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Query Syntax
            //// select * from Employees where Age > 25
            //// Limited to 12 Methods

            //var q13 = from e in employees
            //          where e.Age > 25
            //          select e;

            //var q14 = from e in employees
            //          where e.Salary > 5000
            //          orderby e.Name descending
            //          select e;

            //var q15 = from e in employees
            //          where e.DeptId == 3
            //          select e;

            //var q16 = from e in employees
            //          where e.DeptId == 1 && e.Age > 25
            //          select e;

            //var q17 = from e in employees
            //          where e.Id == 1
            //          select e;

            //Console.WriteLine(q17); // XXXXXXX
            //foreach (var item in q13)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Single Element => Return One Element Only
            // First
            // FirstOrDefault
            // Last
            // LastOrDefault
            // Single
            // SingleOrDefault
            // ElementAt
            // ElementAtOrDefault
            // Find => EF

            #region First and FirstOrDefault
            ////Employee q18 = employees.First();
            //var q19 = employees.First();
            //var q20 = employees.First(e=>e.DeptId == 2);
            //var q21 = employees.First(e=>e.DeptId == 2555555);

            //// First 
            //// 1- Return First Element Only
            //// 2- If No Element => Throw Exception => Sequence contains no matching element
            //// 3- If Found => Return Element
            //// 4- If More Than One => Return First Only

            //var q22 = employees.FirstOrDefault();
            //var q23 = employees.FirstOrDefault(e => e.DeptId == 2);
            //var q24 = employees.FirstOrDefault(e => e.DeptId == 2555555);
            //Console.WriteLine(q24);
            //if (q24 == null)
            //{
            //    Console.WriteLine("No Element Found");
            //}

            //// FirstOrDefault
            //// 1- Return First Element Only
            //// 2- If No Element => Return Default Value => null for reference type and 0 for value type
            //// 3- If Found => Return Element
            //// 4- If More Than One => Return First Only
            #endregion

            #region Last and LastOrDefault
            //var q25 = employees.Last();
            //var q26 = employees.Last(e=>e.DeptId == 1);
            //var q27 = employees.Last(e=>e.DeptId == 15);
            //Console.WriteLine(q26);

            //// Last
            //// 1- Return Last Element Only
            //// 2- If No Element => Throw Exception => Sequence contains no matching element
            //// 3- If Found => Return Element
            //// 4- If More Than One => Return Last Only

            //var q28 = employees.LastOrDefault();
            //var q29 = employees.LastOrDefault(e => e.DeptId == 1);
            //var q30 = employees.LastOrDefault(e => e.DeptId == 15);
            //Console.WriteLine(q30);

            //// LastOrDefault
            //// 1- Return Last Element Only
            //// 2- If No Element => Return Default Value => null for reference type and 0 for value type
            //// 3- If Found => Return Element
            //// 4- If More Than One => Return Last Only
            #endregion

            #region Single and SingleOrDefault
            // Single => Return Single Element Only
            //var q31 = employees.Single(e => e.Id == 1);
            //var q32 = employees.Single(e => e.Id == 10000);
            //var q33 = employees.Single(e => e.DeptId == 1);
            //Console.WriteLine(q33);

            //// Single
            //// 1- Return Single Element Only
            //// 2- If No Element => Throw Exception => Sequence contains no matching element
            //// 3- If one Found => Return Element
            //// 4- If More Than One => Throw Exception => Sequence contains more than one matching element

            // SingleOrDefault => Return Single Element Only
            //var q34 = employees.SingleOrDefault(e => e.Id == 1);
            //var q35 = employees.SingleOrDefault(e => e.Id == 10000);
            //var q36 = employees.SingleOrDefault(e => e.DeptId == 1);
            //Console.WriteLine(q36);

            //// SingleOrDefault
            //// 1- Return Single Element Only
            //// 2- If No Element => Return Default Value => null for reference type and 0 for value type
            //// 3- If one Found => Return Element
            //// 4- If More Than One => Throw Exception => Sequence contains more than one matching element
            #endregion

            #region ElementAt and ElementAtOrDefault
            //// ElementAt => Return Element at Specific Index
            //var q37 = employees.ElementAt(0);
            //var q38 = employees.ElementAt(10000);
            //Console.WriteLine(q37);

            //// ElementAt
            //// 1- Return Element at Specific Index
            //// 2- If Index Out Of Range => Throw Exception => Index was out of range. 
            //// Must be non-negative and less than the size of the collection.
            //// 3- If one Found => Return Element

            //var q39 = employees.ElementAtOrDefault(0);
            //var q40 = employees.ElementAtOrDefault(10000);
            //Console.WriteLine(q40);
            //// ElementAtOrDefault
            //// 1- Return Element at Specific Index
            //// 2- If Index Out Of Range => Return Default Value => null for reference type and 0 for value type
            //// 3- If one Found => Return Element
            #endregion
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
