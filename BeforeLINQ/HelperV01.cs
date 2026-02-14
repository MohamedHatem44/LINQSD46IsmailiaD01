namespace BeforeLINQ
{
    public class HelperV01
    {
        /*------------------------------------------------------------------*/
        public static List<Employee> GetEmployeesWithNameStartWith(string val)
        {
            //List<Employee> employees = Repository.GetEmployees();
            var employees = Repository.GetEmployees();
            var res = new List<Employee>();

            foreach (var emp in employees)
            {
                if (emp.Name.ToLower().StartsWith(val.ToLower()))
                {
                    res.Add(emp);
                }
            }
            return res;
        }
        /*------------------------------------------------------------------*/
        public static List<Employee> GetEmployeesWithNameEndWith(string val)
        {
            //List<Employee> employees = Repository.GetEmployees();
            var employees = Repository.GetEmployees();
            var res = new List<Employee>();

            foreach (var emp in employees)
            {
                if (emp.Name.ToLower().EndsWith(val.ToLower()))
                {
                    res.Add(emp);
                }
            }
            return res;
        }
        /*------------------------------------------------------------------*/
        public static List<Employee> GetEmployeesWithNameContains(string val)
        {
            //List<Employee> employees = Repository.GetEmployees();
            var employees = Repository.GetEmployees();
            var res = new List<Employee>();

            foreach (var emp in employees)
            {
                if (emp.Name.ToLower().Contains(val.ToLower()))
                {
                    res.Add(emp);
                }
            }
            return res;
        }
        /*------------------------------------------------------------------*/
    }
}
