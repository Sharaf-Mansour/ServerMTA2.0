namespace ServerMTA.Pages;
public partial class ExamScore
{
    private static string StringScore => ScorePerc.ToString("0.##") + "%";
    private static double ScorePerc => ((double)ExamController.Score / (double)ExamController.CountAll) * 100;
    private void NavigateToComponent(string Report) => NavigationManager.NavigateTo(Report);
}