namespace L02_RepetitionUML.School;

public class Professor : Person
{
    private int _yearsOfServices;
    // you can ommit the type in "new", the compiler already knows it
    private List<Student> _supervisedStudents = new();
    
    public int Salary
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public int NumberOfClasses { get; }

    // Implements
    public List<Student> SupervisedStudents
    {
        get
        {
            return _supervisedStudents;
        }
    }
    
    protected int StaffNumber { get; set; }
    
    public override void PurchaseParkingPass()
    {
        throw new NotImplementedException();
    }
}
