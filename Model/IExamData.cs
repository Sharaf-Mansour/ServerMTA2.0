namespace ServerMTA.Model;
public interface IExamData
{
    public string ExamName();
    public Span<Exam> CurrentExam();
}