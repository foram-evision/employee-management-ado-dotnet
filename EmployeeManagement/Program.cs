List<Employee> employees = new List<Employee>()
{
    new Employee
    {
        Id = 1,
        Name = "Rahul",
        Department = "IT",
        Salary = 50000
    },

    new Employee
    {
        Id = 2,
        Name = "Priya",
        Department = "HR",
        Salary = 45000
    },

    new Employee
    {
        Id = 3,
        Name = "Amit",
        Department = "IT",
        Salary = 70000
    }
};

var emp =
employees.FirstOrDefault(e => e.Id == 1);

Console.WriteLine(emp.Name);