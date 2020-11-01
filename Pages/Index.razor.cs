using Microsoft.AspNetCore.Components;
using ServerMTA.Model;
namespace ServerMTA.Pages
{
    public partial class Index
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }

        private void NavigateToComponent(string Report)
        {
            NavigationManager.NavigateTo(Report);
            ExamMTA.ResetExam();

            if (ExamMTA.ShuffleQeustion)
            {
                ExamMTA.ShuffleQeustions();
            }
            else
            {
                ExamMTA.SortQeustion();
            }

            if (ExamMTA.ShuffleAnswer)
            {
                ExamMTA.ShuffleAnswers();
            }
            else
            {
                ExamMTA.SortAnswer();
            }
            ExamMTA.Numrize();
        }
    }
}