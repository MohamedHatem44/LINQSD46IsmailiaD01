namespace BeforeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            #region V01
            //// Get All Employees With Name start with "MO"
            //Console.WriteLine("V01 Emplyees Start With MO");
            //var res1 = HelperV01.GetEmployeesWithNameStartWith("MO");
            //foreach (var emp in res1)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region V02
            //var employees = Repository.GetEmployees();
            //Predicate<Employee> predicate = emp => emp.Name.ToLower().StartsWith("MO".ToLower());
            //Console.WriteLine("V02 Emplyees Start With MO");
            //var res2 = HelperV02.FilterEmployees(employees, predicate);
            //var res3 = HelperV02.FilterEmployees(employees, emp => emp.Name.ToLower().StartsWith("MO".ToLower()));
            //var res4 = HelperV02.FilterEmployees(employees, emp => emp.Name.ToLower().EndsWith("MO".ToLower()));
            //var res5 = HelperV02.FilterEmployees(employees, emp => emp.Name.ToLower().Contains("MO".ToLower()));
            //var res6 = HelperV02.FilterEmployees(employees, emp => emp.DeptId == 1);
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region V03 => Extention Method
            //var employees = Repository.GetEmployees();
            //Console.WriteLine("V03 Emplyees Start With MO");
            //var res7 = HelperV03.FilterEmployees(employees, emp => emp.Name.ToLower().StartsWith("MO".ToLower()));
            //var res8 = employees.FilterEmployees(emp => emp.Name.ToLower().StartsWith("MO".ToLower()));
            //foreach (var item in res8)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
