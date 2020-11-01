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
    public partial class Index
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }

        private void NavigateToComponent(string Report)
        {
            NavigationManager.NavigateTo(Report);
            ExamMTA.ResetExam();

            if (ExamMTA.ShuffleQeustion)
            {
                ExamMTA.ShuffleQeustions();
            }
            else
            {
                ExamMTA.SortQeustion();
            }

            if (ExamMTA.ShuffleAnswer)
            {
                ExamMTA.ShuffleAnswers();
            }
            else
            {
                ExamMTA.SortAnswer();
            }
            ExamMTA.Numrize();
        }
    }
}