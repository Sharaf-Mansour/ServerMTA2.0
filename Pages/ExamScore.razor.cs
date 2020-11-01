
using Microsoft.AspNetCore.Components;
using ServerMTA.Model;

namespace ServerMTA.Pages
{
    public partial class ExamScore
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }
        private static string StringScore => ScorePerc.ToString("0.##") + "%";
        private static double ScorePerc => (ExamMTA.Score / 79) * 100;
        private void NavigateToComponent(string Report) => NavigationManager.NavigateTo(Report);

    }
}
