using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerMTA.Model
{
    public record Exam(int ID, List<Answer> Answers, string Value = "");
    public record Answer(int ID, string Value, bool IsCorrect, bool IsSelected = false);
    public record Score(int ID, bool IsCorrect = false);
}