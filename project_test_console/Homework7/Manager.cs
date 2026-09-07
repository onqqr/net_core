namespace project_test_console;

public class Manager : Employee {
    public Manager(string name, double salary)
        : base(name, salary) {}

    public override double CalculateBonus() {
        return salary * 0.15;
    }
}