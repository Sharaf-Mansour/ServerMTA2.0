using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace ServerMTA.Model
{
    public class ExamMTA : ExamMTAData
    {
        public static string ExamName => "MTA 98-361";

        public static List<Exam> Exams98_361 { get; set; } = Exams98_361Static;
      
     //   public void SetExam(List<Exam> Exam) => Exams98_361 = Exams98_361Static = Exam;
        public static double Score => Exams98_361.Count(x => x.IsCorrect);
        public static double CountAll => Exams98_361.Count;
        public static double CountFlagged => Exams98_361.Count(x => x.IsFlagged);
        public static double CountNotAnswered => Exams98_361.Count(x => x.Answers.Any(i => i.IsSelected) == false);
        public static bool AllowShowAnswer { get; set; }
        public static bool ShuffleAnswer { get; set; }
        public static bool ShuffleQeustion { get; set; }
        public static void SortQeustion() => Exams98_361.OrderBy(x => x.ID);
        public static void SortAnswer() => Exams98_361.ForEach(x => x.Answers.OrderBy(x => x.ID));
        public static void ShuffleQeustions() => Exams98_361.Shuffle();
        public static void ShuffleAnswers() => Exams98_361.ForEach(x => x.Answers.Shuffle());
        public static void ClearRadioAnswer(Exam exam) => exam.Answers.ForEach(x => x.IsSelected = false);
        //  public static void ResetExam() => Exams98_361.ForEach(x =>
        // {
        //     (x.IsCorrect, x.IsFlagged) = (false, false);
        //     x.Answers.ForEach(i => i.IsSelected = false);
        //  });
        public static void ResetExam() => Exams98_361 = Exams98_361Static;

        public static void Numrize(int Number = 1) => Exams98_361.ForEach(x => x.Num = Number++);

       

    }
}
