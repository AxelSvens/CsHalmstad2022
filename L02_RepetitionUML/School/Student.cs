namespace L02_RepetitionUML.School;

public class Student : Person
{
    public int StudentNumber { get; set; }
    public int AverageMark { get; set; }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="courseName">The name of the course</param>
    /// <returns>True if eligible, false otherwise</returns>
    /// <exception cref="NotImplementedException">Thrown when the course does not exist</exception>
    public bool IsEligibleToEnroll(string courseName)
    {
        throw new NotImplementedException();
    }

    public int GetSeminarsTaken()
    {
        throw new NotImplementedException();
    }

    public override void PurchaseParkingPass()
    {
        throw new NotImplementedException();
    }
}