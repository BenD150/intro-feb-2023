using Finger;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "host=localhost;database=status_dev;password=TokyoJoe138!;username=postgres;port=5432";

var app = builder.Build();

app.MapGet("/status", () => {
    var status = new StatusMessage("All is Good!", DateTimeOffset.Now);
    return status;
});

app.MapPost("/status", (StatusRequest req) => {
    return req;
});

app.Run(); // Blocking call

public record StatusRequest(string Message);