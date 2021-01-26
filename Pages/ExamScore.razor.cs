
using Microsoft.AspNetCore.Components;
using ServerMTA.Model;

namespace ServerMTA.Pages
{
    public partial class ExamScore
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }
        private static string StringScore => ScorePerc.ToString("0.##") + "%";
        private static double ScorePerc => ((double)ExamController.Score / (double)ExamController.CountAll) * 100;
        private void NavigateToComponent(string Report) => NavigationManager.NavigateTo(Report);

    }
}
