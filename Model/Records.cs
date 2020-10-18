using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerMTA.Model
{
    public enum ControlType { CheackBox, RadioButton, YesNo };
    public record Exam(int ID, List<Answer> Answers, string Value = "", ControlType Type = ControlType.RadioButton);
    public record Answer(int ID, string Value, bool IsCorrect, bool IsSelected = false);
    public record Score(int ID, bool IsCorrect = false);
    public record MarkForReview(int Num,bool IsMarked = false);
}