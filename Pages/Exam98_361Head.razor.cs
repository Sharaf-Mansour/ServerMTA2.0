namespace ServerMTA.Pages;
public partial class Exam98_361Head
{
    public static bool HasRefreshed = true;
    [Parameter] public int QNumber { get; set; }
    private bool ShowAnswer;
    private bool CorrectAnswer;
    private Exam Qeustion => ExamController.CurrentExam[(QNumber - 1) % (ExamController.CountAll + 1)];
    private void NavigateToComponent(string Report)
    {
        (ShowAnswer, CorrectAnswer) = (false, false);
        NavigationManager.NavigateTo(Report);
    }
    protected override void OnInitialized()
    {
        if (HasRefreshed)
        {
            NavigationManager.NavigateTo(MetaData.Url+"/");
            StateHasChanged();
        }
    }
    private void Marker(ChangeEventArgs args) => Qeustion.IsFlagged = (bool)(args.Value ?? false);
    private void RadioSelection(Answer I)
    {
        ExamController.ClearRadioAnswer(Qeustion);
        (I.IsSelected, ShowAnswer) = (true, true);
        CorrectAnswer = I.IsSelected == I.IsCorrect;
        Qeustion.IsCorrect = CorrectAnswer;
    }
    private void CheckSelection(ChangeEventArgs __e, Answer I)
    {
        (CorrectAnswer, ShowAnswer) = (false, true);
        Qeustion.Answers.Where(x => x.ID == I.ID).Single().IsSelected = (bool)(__e.Value ?? false);
        var CorrectAnswersCount = Qeustion.Answers.Count(x => x.IsCorrect);
        var SelectsAnswers = Qeustion.Answers.Where(x => x.IsSelected).Select(_ => _).ToList();
        foreach (var item in SelectsAnswers)
        {
            if (!item.IsCorrect)
            {
                CorrectAnswer = false;
                break;
            }
            CorrectAnswer = SelectsAnswers.Count == CorrectAnswersCount;
        }
        Qeustion.IsCorrect = CorrectAnswer;
    }
}