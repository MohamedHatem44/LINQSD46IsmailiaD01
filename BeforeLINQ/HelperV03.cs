namespace BeforeLINQ
{
    public static class HelperV03
    {
        /*------------------------------------------------------------------*/
        public static List<Employee> FilterEmployees(
           this IEnumerable<Employee> employees,
           Predicate<Employee> predicate)
        {
            // External Dependency
            //List<Employee> employees = Repository.GetEmployees();
            //var employees = Repository.GetEmployees();
            var res = new List<Employee>();

            foreach (var emp in employees)
            {
                if (predicate(emp) == true)
                {
                    res.Add(emp);
                }
            }
            return res;
        }
        /*------------------------------------------------------------------*/
    }
}
