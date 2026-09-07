using project_test_console;

// Homework1.Run();
// Homework2.Run();
// Homework3.Run();
// Homework4.Run();
// Homework5.Run();
// var account = new BankAccount("Pavel Hetsman", "9986555278", 987);

// -----------------------
// homework7 test
var developer = new Developer("Pavel", 5000);
var designer = new Designer("Liza", 2345);
var manager = new Manager("Maria", 7654);
var employees = new List<Employee>();

employees.Add(developer);
employees.Add(designer);
employees.Add(manager);

foreach (var employee in employees)
{
    employee.GetInfo();
    Console.WriteLine($"bonus: {employee.CalculateBonus()}");
}
// --------------------- --
