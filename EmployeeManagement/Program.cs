using Dapper;
using Npgsql;

string connectionString =
"Host=localhost;Port=5432;Database=EmployeeDB;Username=postgres;Password=Welcome@123";

using var con =
new NpgsqlConnection(connectionString);

var employees =
con.Query<Employee>(
"SELECT * FROM GetEmployees()"
).ToList();

foreach (var emp in employees)
{
    Console.WriteLine(
        $"{emp.Name} - {emp.Department}"
    );
}