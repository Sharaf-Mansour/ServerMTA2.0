var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.Services.AddScoped<ExamController>();
MetaData.Url = builder.HostEnvironment.BaseAddress;
await builder.Build().RunAsync();