namespace PersonalregisterLexicon;

class Program
{
    static EmployeeManager _employeeManager = new EmployeeManager();
    
    static void Main(string[] args)
    {
        bool programRunning = true;
        while (programRunning)
        {
            Console.Write("(1) Add new employee (2) List employees (q) Exit program : ");
            char command = Console.ReadKey().KeyChar; // Reading with this over Console.WriteLine
            Console.WriteLine(); // Empty line to go to next line
            switch (command)
            {
                case '1':
                    AddEmployeeCommand();
                    break;
                case '2':
                    _employeeManager.ListEmployees();
                    break;
                case 'q':
                case 'Q':
                    programRunning = false;
                    break;
                default:
                    Console.WriteLine("Unknown command, try again");
                    break;
            }
        }
    }

    static void AddEmployeeCommand()
    {
        Console.Write("What is the new employee's name: ");
        string? name = Console.ReadLine();
        ulong salary = 0;
        while (true)
        {
            Console.Write("What is the new employee's salary: ");
            string salaryStr = Console.ReadLine();
            if (ulong.TryParse(salaryStr, out salary))
            {
                break;
            }
            else
            {
                Console.WriteLine("INVALID SALARY, TRY AGAIN");
            }
        }
        _employeeManager.AddEmployee(name, salary);
    }
    static void ListEmployeesCommand()
    {
        
    }
}

public class EmployeeManager()
{
    private List<Employee> employees = new List<Employee>();
    
    public void AddEmployee(string name, ulong salary)
    { 
        employees.Add(new Employee(name, salary));
    }
    
    public void ListEmployees()
    {
        
    }
}

public class Employee
{
    public Guid Id { get; }
    public ulong Salary { get; set; }
    public string Name { get; set; }

    public Employee(string name, ulong salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Salary = salary;
    }
}