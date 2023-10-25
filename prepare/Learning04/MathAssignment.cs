class MathAssignment : Assignment
{
    private int _sectionNumber;
    private string _problems;
    
    public MathAssignment(string name, string topic, int sectionNumber, string problems) : base(name, topic) {
        _sectionNumber = sectionNumber;
        _problems = problems;
    }
    public void GetHomeworkList() {
        System.Console.WriteLine("Section " + _sectionNumber.ToString() + " " + _problems);
    }
}