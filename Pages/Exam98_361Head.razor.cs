using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using ServerMTA;
using ServerMTA.Shared;
using ServerMTA.Model;

namespace ServerMTA.Pages
{
    public partial class Exam98_361Head
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }

        [Parameter] public int QNumber { get; set; }
        public bool ShowAnswer;
        string RadioValue = "";
        public bool CorrectAnswer;
        public Exam Qeustion => ExamMTA.Exams98_361[(QNumber - 1) % 79];
        private void NavigateToComponent(string Report)
        {
            (ShowAnswer, CorrectAnswer) = (false, false);
            NavigationManager.NavigateTo(Report);
        }

        void Marker(ChangeEventArgs args) => ExamMTA.MarkForReviewList.Where(x => x.Num == QNumber).Single().IsMarked = (bool)args.Value;
        void RadioSelection(ChangeEventArgs args, Answer I)
        {
            ExamMTA.ClearRadioAnswer(Qeustion);
            Qeustion.Answers.Where(x => x.ID == I.ID).Single().IsSelected = true;
            (ShowAnswer, RadioValue) = (true, args.Value.ToString());
            CorrectAnswer = (
                from item in Qeustion.Answers
                where item.Value == RadioValue
                select item.IsCorrect).FirstOrDefault<bool>();
            ExamMTA.Scores98_361[(QNumber - 1) % 79].IsCorrect = CorrectAnswer;
        }

        void CheckSelection(ChangeEventArgs __e, Answer I)
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

                CorrectAnswer = true;
            }

            if (SelectsAnswers.Count != CorrectAnswersCount)
            {
                CorrectAnswer = false;
            }

            ExamMTA.Scores98_361[(QNumber - 1) % 79].IsCorrect = CorrectAnswer;
        }
    }
}