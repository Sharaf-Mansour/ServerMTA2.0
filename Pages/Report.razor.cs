using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
namespace ServerMTA.Pages
{
    public partial class Report
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }
        [Inject] protected IJSRuntime JSRuntime { get; set; }
        private void NavigateToComponent(string Report) => NavigationManager.NavigateTo(Report);
        private IJSInProcessRuntime JsInProcess => (IJSInProcessRuntime)JSRuntime;
        private void Print() => JsInProcess.InvokeVoid("window.printwindow", null);

    }
}