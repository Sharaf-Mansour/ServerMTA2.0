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
    public partial class Report
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }
[Inject] protected IJSRuntime JSRuntime { get; set; }
        private void NavigateToComponent(string Report) => NavigationManager.NavigateTo(Report);
        string printCSS = "";
        int QNumber = 0;
        void print()
        {
            StateHasChanged();
            QNumber = 0;
            var jsInProcess = (IJSInProcessRuntime)JSRuntime;
            jsInProcess.InvokeVoid("window.printwindow", null);
        }
    }
}