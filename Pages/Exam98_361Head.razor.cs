using System.Linq;
using Microsoft.AspNetCore.Components;
using ServerMTA.Model;
namespace ServerMTA.Pages
{
    public partial class Exam98_361Head
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }

        [Parameter] public int QNumber { get; set; }
        private bool ShowAnswer;
        private bool CorrectAnswer;
        private Exam Qeustion => ExamMTA.Exams98_361[(QNumber - 1) % 79];
        private void NavigateToComponent(string Report)
        {
            (ShowAnswer, CorrectAnswer) = (false, false);
            NavigationManager.NavigateTo(Report);
        }

        // protected override void OnInitialized() => Qeustion.Num = QNumber;

        private void Marker(ChangeEventArgs args) => Qeustion.IsFlagged = (bool)args.Value;
        private void RadioSelection(Answer I)
        {
            ExamMTA.ClearRadioAnswer(Qeustion);
            (I.IsSelected, ShowAnswer) = (true, true);
            CorrectAnswer = I.IsSelected == I.IsCorrect;
            Qeustion.IsCorrect = CorrectAnswer;
        }
        private void CheckSelection(ChangeEventArgs __e, Answer I)
        {
            (CorrectAnswer, ShowAnswer) = (false, true);
            Qeustion.Answers.Where(x => x.ID == I.ID).Single().IsSelected = (bool)__e.Value;
            var CorrectAnswersCount = (
                from item in Qeustion.Answers
                where item.IsCorrect == true
                select item).Count();
            var SelectsAnswers = (
                from item in Qeustion.Answers
                where item.IsSelected == true
                select item).ToList();
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
}