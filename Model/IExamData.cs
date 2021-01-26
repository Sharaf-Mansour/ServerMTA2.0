using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerMTA.Model
{
    public interface IExamData
    {
        public string ExamName();
        public List<Exam> CurrentExam();
    }
}
