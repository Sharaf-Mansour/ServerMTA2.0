namespace ServerMTA.Pages;
public partial class Report
{
    private void NavigateToComponent(string Report) => NavigationManager.NavigateTo(Report);
    private IJSInProcessRuntime JsInProcess => (IJSInProcessRuntime)JSRuntime;
    private void Print() => JsInProcess.InvokeVoid("window.printwindow", null);
}