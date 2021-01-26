using Microsoft.AspNetCore.Components;
using ServerMTA.Model;
namespace ServerMTA.Pages
{
    public partial class Index
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }

        private void SetExam(IExamData ExamSource) => ExamController.DataSource = ExamSource;

        private void NavigateToComponent(string Report)
        {

            ExamController.ResetExam();

            if (ExamController.ShuffleQeustion)
            {
                ExamController.ShuffleQeustions();
            }
            else
            {
                ExamController.SortQeustion();
            }

            if (ExamController.ShuffleAnswer)
            {
                ExamController.ShuffleAnswers();
            }
            else
            {
                ExamController.SortAnswer();
            }
            ExamController.Numrize();
            Exam98_361Head.HasRefreshed = false;
            NavigationManager.NavigateTo(Report);
        }
    }
}