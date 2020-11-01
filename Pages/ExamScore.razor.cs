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
    public partial class ExamScore
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }
        private static string StringScore => ScorePerc.ToString("0.##") + "%";
        private static double ScorePerc => (ExamMTA.Score / 79) * 100;
        private void NavigateToComponent(string Report) => NavigationManager.NavigateTo(Report);

    }
}
