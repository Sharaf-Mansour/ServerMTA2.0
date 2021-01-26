using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMTA.Model
{
    public class ExamController
    {
        public static IExamData DataSource { get; set; } = new ExamAIData();
        public static string ExamName() => DataSource.ExamName();

        public static Exam[] CurrentExam { get; set; } = DataSource.CurrentExam();

        //   public void SetExam(List<Exam> Exam) => CurrentExam = Exams98_361Static = Exam;
        public static int Score => CurrentExam.Count(x => x.IsCorrect);
        public static int CountAll => CurrentExam.Length;
        public static int CountFlagged => CurrentExam.Count(x => x.IsFlagged);
        public static int CountNotAnswered => CurrentExam.Count(x => x.Answers.Any(i => i.IsSelected) == false);
        public static bool AllowShowAnswer { get; set; }
        public static bool ShuffleAnswer { get; set; }
        public static bool ShuffleQeustion { get; set; }
        public static void SortQeustion() => CurrentExam.OrderBy(x => x.ID);

        public static void SortAnswer()
        {
            for (int i = 0; i < CountAll; i++)
            {
                CurrentExam[i].Answers.OrderBy(x => x.ID);
            }
        }

        public static void ShuffleQeustions() => CurrentExam.Shuffle();

        public static void ShuffleAnswers()
        {
            for (int i = 0; i < CountAll; i++)
            {
                CurrentExam[i].Answers.Shuffle();
            }
        }

        public static void ClearRadioAnswer(Exam exam)
        {
            for (int i = 0; i < exam.Answers.Length; i++)
            {
                exam.Answers[i].IsSelected = false;
            }
        }
        //  public static void ResetExam() => CurrentExam.ForEach(x =>
        // {
        //     (x.IsCorrect, x.IsFlagged) = (false, false);
        //     x.Answers.ForEach(i => i.IsSelected = false);
        //  });
        public static void ResetExam() => CurrentExam = DataSource.CurrentExam();

        public static void Numrize(int Number = 1)
        {
            for (int i = 0; i < CountAll; i++)
            {
                CurrentExam[i].Num = Number++;
            }
            //CurrentExam.ToList().ForEach(x => x.Num = Number++);

        }


    }
}
