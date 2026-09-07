namespace project_test_console;

public class Designer : Employee {
    public Designer(string name, double salary)
        : base(name, salary) {}

    public override double CalculateBonus() {
        return salary * 0.12;
    }
}