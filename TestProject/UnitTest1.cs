using PersonalregisterLexicon;

namespace PersonalregisterTest;

public class Tests
{
    private EmployeeManager _employeeManager;
    [SetUp]
    public void Setup()
    {
        _employeeManager = new EmployeeManager();
    }

    public void CreateTestEmployees()
    {
        _employeeManager.AddEmployee("Alice",10000);
        _employeeManager.AddEmployee("Bob",20000);
    }
    [Test]
    public void CanCreateEmployees()
    {
        CreateTestEmployees();
        Assert.Pass();
    }
    [Test]
    public void CanListEmployees()
    {
        CreateTestEmployees();
        _employeeManager.ListEmployees();
        Assert.Pass();
    }
}