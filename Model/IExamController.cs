using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMTA.Model
{
    public class ExamMTA : ExamAIData
    {
        public static string ExamName => "AI-900";

        public static List<Exam> CurrentExam { get; set; } = Exams100Static;

        //   public void SetExam(List<Exam> Exam) => CurrentExam = Exams98_361Static = Exam;
        public static int Score => CurrentExam.Count(x => x.IsCorrect);
        public static int CountAll => CurrentExam.Count;
        public static int CountFlagged => CurrentExam.Count(x => x.IsFlagged);
        public static int CountNotAnswered => CurrentExam.Count(x => x.Answers.Any(i => i.IsSelected) == false);
        public static bool AllowShowAnswer { get; set; }
        public static bool ShuffleAnswer { get; set; }
        public static bool ShuffleQeustion { get; set; }
        public static void SortQeustion() => CurrentExam.OrderBy(x => x.ID);
        public static void SortAnswer() => CurrentExam.ForEach(x => x.Answers.OrderBy(x => x.ID));
        public static void ShuffleQeustions() => CurrentExam.Shuffle();
        public static void ShuffleAnswers() => CurrentExam.ForEach(x => x.Answers.Shuffle());
        public static void ClearRadioAnswer(Exam exam) => exam.Answers.ForEach(x => x.IsSelected = false);
        //  public static void ResetExam() => CurrentExam.ForEach(x =>
        // {
        //     (x.IsCorrect, x.IsFlagged) = (false, false);
        //     x.Answers.ForEach(i => i.IsSelected = false);
        //  });
        public static void ResetExam() => CurrentExam = Exams100Static;

        public static void Numrize(int Number = 1) => CurrentExam.ForEach(x => x.Num = Number++);



    }
}
