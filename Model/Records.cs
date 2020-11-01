using System.Collections.Generic;

namespace ServerMTA.Model
{
    public enum ControlType { CheackBox, RadioButton, YesNo };
    public record Exam(int ID, List<Answer> Answers, string Value = "", ControlType Type = ControlType.RadioButton, bool IsCorrect = false, bool IsFlagged = false, int Num = 0)
    {
        public bool IsCorrect { get; set; } = IsCorrect;
        public bool IsFlagged { get; set; } = IsFlagged;
        public int Num { get; set; } = Num;
    }
    public record Answer(int ID, string Value, bool IsCorrect = false, bool IsSelected = false) { public bool IsSelected { get; set; } = IsSelected; }
}