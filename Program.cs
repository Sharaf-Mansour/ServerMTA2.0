var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.Services.AddScoped<ExamController>();
await builder.Build().RunAsync();