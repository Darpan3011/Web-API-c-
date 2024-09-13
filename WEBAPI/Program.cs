var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// middlewares
app.UseHttpsRedirection();
//app.UseAuthentication();
//app.UseRouting();
//app.UseAuthorization();
// many more..

//app.MapGet("/shirts", () =>
//{

//    return "All the shirts listed here";
//});

//app.MapGet("/shirts/{id}", (int id) => {

//    return $"Shirts with id {id}";
//});

//app.MapPost("/shirts", () =>
//{
//    return "Creating a shirt.";
//});

//app.MapPut("/shirts/{id}", (int id) => {

//    return $"updating shirt with id {id}";
//});


// instead above we use importing controllers

app.MapControllers();


app.Run();